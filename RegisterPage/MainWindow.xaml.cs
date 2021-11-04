using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using RegisterPage.Models;

namespace RegisterPage
{
    
    public partial class MainWindow : Window 
    {
        private PlayerContext playerContext = new PlayerContext();
        private string verificationCode;

        public MainWindow()
        {
            InitializeComponent();            
            
        }

        private void ValidUser(object sender, RoutedEventArgs e)
        {

            FieldsValidator validator = new FieldsValidator();

            Player player = new Player(textBoxNickname.Text, textBoxPassword.Text,
                textBoxName.Text, textBoxLastName.Text, textBoxEmail.Text);
            FluentValidation.Results.ValidationResult result = validator.Validate(player);

            if (!result.IsValid)
            {
                ShowErrors(result);
            }
            else
            {
                if (textBoxPassword.Text.Equals(textBoxReEnterPassword.Text))
                    textBoxReEnterPassword.BorderBrush = Brushes.White;

                var uniqueNickName =
                    playerContext.Database.SqlQuery<Player>("SELECT * FROM Player WHERE Nickname=@nickname",
                    new SqlParameter("@nickname", textBoxNickname.Text));

                if (uniqueNickName.Count() == 0)
                {
                    ChangeAllBorderBrushesToWhite();
                    if (textBoxPassword.Text.Equals(textBoxReEnterPassword.Text))
                    {
                        textBoxReEnterPassword.BorderBrush = Brushes.White;
                        SendNewConfirmationCode();

                        bool close = false;
                        stackPanelBlack.Visibility = Visibility.Visible;

                        do
                        {
                            MessageBoxCustom messageBoxCustom = new MessageBoxCustom(Properties.Langs.Lang.verificationCodeMessage,
                               MessageType.Submit, MessageButtons.Submit, true);
                            messageBoxCustom.ShowDialog();
                            if (messageBoxCustom.GetDialog())
                            {

                                string verificationCodeUser = messageBoxCustom.GetCode();
                                if (verificationCodeUser.Equals(verificationCode))
                                {
                                    
                                    RegisterNewAccount();
                                    break;
                                }
                                else
                                {                                    
                                    MessageBoxConfirmation messageBoxFailedVerification =
                                        new MessageBoxConfirmation(Properties.Langs.Lang.failedVerification, MessageButtons.Ok);
                                    messageBoxFailedVerification.ShowDialog();
                                }
                            }
                            else
                            {                                
                                MessageBoxConfirmation messageBoxConfirmation =
                                    new MessageBoxConfirmation(Properties.Langs.Lang.confirmationMessage, MessageButtons.AcceptCancel);
                                bool? messageConfirmationResult = messageBoxConfirmation.ShowDialog();

                                if (messageConfirmationResult.Value)
                                {
                                    close = true;
                                }

                            }
                        } while (close == false);
                        stackPanelBlack.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        
                        stackPanelBlack.Visibility = Visibility.Visible;
                        new MessageBoxCustom(Properties.Langs.Lang.passwordMismatchErrorMessage,
                                      MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                        stackPanelBlack.Visibility = Visibility.Collapsed;
                        textBoxReEnterPassword.BorderBrush = Brushes.Red;

                    }
                }
                else
                {
                    
                    stackPanelBlack.Visibility = Visibility.Visible;
                    new MessageBoxCustom(Properties.Langs.Lang.existingNicknameMessage,
                                     MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                    stackPanelBlack.Visibility = Visibility.Collapsed;
                    textBoxNickname.BorderBrush = Brushes.Red;
                }

            }

        }

        public void SendNewConfirmationCode()
        {
            MailDelivery mailDelivery = new MailDelivery();
            string body =
                @"<html>
                    <style>                       
                        div {font-family: 'PT Sans', sans-serif;}                                  
                        .container {width: min(90%, 120rem); margin: 0 auto;}
                        .header {height: 10rem; background-size: cover; background-repeat: no-repeat; background-position: center center;}
                        .header__text {text-align: center;}
                        .center-text {text-align: center;}
                        .bar {display: flex; justify-content: space-between; align-items: center;}                                                               
                        .navigation {display: flex;}               
                        .image {display: flex; align-items: center;}                                                              
                    </style>

                    <header style=' background-image: url(cid:background); height: 10rem; background-size: cover; background-repeat: no-repeat; background-position: center center;'>        
                        <div style=' width: min(90%, 120rem); margin: 0 auto;'>
                            <div style=' display: flex; justify-content: space-between; align-items: center;'>                                            
                                <h1 style=' color: #545454; text-align: center;'>RumMichy</h1>
                                <img src=cid:smallMichyID alt='RumMichy michy'>                                                                          
                            </div>            
                        </div>                
                    </header>

                    <div style=' text-align: center;'>
                        <h1 style=' color: #FF83C6;'>{welcomeMessage}</h1></br>      
                         <h2 style=' color: #8C6CFF;'>{verificationCodeMessage} {verificationCode}</h2>                         
                        <img src=cid:footPrintID alt='RumMichy footprint'>             
                    </div> 

                </html>";

            verificationCode = GenerateUniqueID(true);

            body = body.Replace("{welcomeMessage}", Properties.Langs.Lang.welcomeMessage);
            body = body.Replace("{verificationCodeMessage}", Properties.Langs.Lang.verificationCodeMessageEmail);
            body = body.Replace("{verificationCode}", verificationCode);
            
            bool result = mailDelivery.SendMail(textBoxEmail.Text, Properties.Langs.Lang.emailMessage, body);
            if (result == false)
            {
                stackPanelBlack.Visibility = Visibility.Visible;
                new MessageBoxCustom(Properties.Langs.Lang.internetConnectionErrorMessage,
                                     MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                stackPanelBlack.Visibility = Visibility.Collapsed;
            }
        }

        public void ChangeAllBorderBrushesToWhite()
        {
            textBoxNickname.BorderBrush = Brushes.White;
            textBoxPassword.BorderBrush = Brushes.White;
            textBoxName.BorderBrush = Brushes.White;
            textBoxLastName.BorderBrush = Brushes.White;
            textBoxEmail.BorderBrush = Brushes.White;
        }

        public void RegisterNewAccount()
        {
            
            string encryptedPassword = Encrypt.GetSHA256(textBoxPassword.Text);

            string id = GenerateUniqueID(false);

            int consult = playerContext.Database.ExecuteSqlCommand(
                 "INSERT INTO Player (ID, Nickname, Password, Name, LastName, Email, Trophies, Michicoins)" +
                 "VALUES (@id, @nickname, @password, @name, @lastName, @email, @trophies, @michicoins)",
                  new SqlParameter("@id", id),
                  new SqlParameter("@nickName", textBoxNickname.Text),
                  new SqlParameter("@password", encryptedPassword),
                  new SqlParameter("@name", textBoxName.Text),
                  new SqlParameter("@lastName", textBoxLastName.Text),
                  new SqlParameter("@email", textBoxEmail.Text),
                  new SqlParameter("@trophies", '0'),
                  new SqlParameter("@michicoins", "100"));

            if (consult == 1)
            {

                new MessageBoxCustom(Properties.Langs.Lang.registeredAccountMessage,
                        MessageType.Success, MessageButtons.Ok, false).ShowDialog();                                
                stackPanelBlack.Visibility = Visibility.Collapsed;
                ClearFields();

            }
            else
            {
                stackPanelBlack.Visibility = Visibility.Visible;
                new MessageBoxCustom(Properties.Langs.Lang.connectionErrorMessage,
                                      MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                stackPanelBlack.Visibility = Visibility.Collapsed;
            }
        }

        public string GenerateUniqueID(bool verificationCode)
        {
            IQueryable<Player> uniqueID;
            var resultString="";
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var charsarray = new char[8];

            if (verificationCode)
                charsarray = new char[7];

            var random = new Random();
            do
            {                                               
                for (int i = 0; i < charsarray.Length; i++)
                {
                    charsarray[i] = characters[random.Next(characters.Length)];
                }

                resultString = new String(charsarray);                                                           
                uniqueID = from id in playerContext.Players
                               where id.ID == resultString
                               select id;
               
            } while (uniqueID.Count() > 0 );

            resultString = "#" + resultString;

            return resultString;
        }

        public void ShowErrors(FluentValidation.Results.ValidationResult result)
        {
            int usernameErrorCounter = 0;
            int passwordErrorCounter = 0;
            int nameErrorCounter = 0;
            int lastNameErrorCounter = 0;
            int emailErrorCounter = 0;
            stackPanelBlack.Visibility = Visibility.Visible;
            foreach (var error in result.Errors)
            {

                if (error.PropertyName.Equals("Nickname") && usernameErrorCounter == 0)
                {                    
                    new MessageBoxCustom(Properties.Langs.Lang.nickNameErrorMessage,
                                        MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                    textBoxNickname.BorderBrush = Brushes.Red;
                    usernameErrorCounter++;
                }
                else if (error.PropertyName.Equals("Password") && passwordErrorCounter == 0)
                {                    
                    new MessageBoxCustom(Properties.Langs.Lang.passwordErrorMessage,
                                       MessageType.Error, MessageButtons.Ok, true).ShowDialog();
                    textBoxPassword.BorderBrush = Brushes.Red;                                       

                    passwordErrorCounter++;
                }
                else if (error.PropertyName.Equals("Name") && nameErrorCounter == 0)
                {                    
                    new MessageBoxCustom(Properties.Langs.Lang.nameErrorMessage,
                                       MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                    textBoxName.BorderBrush = Brushes.Red;
                    nameErrorCounter++;
                }
                else if (error.PropertyName.Equals("LastName") && lastNameErrorCounter == 0)
                {                    
                    new MessageBoxCustom(Properties.Langs.Lang.lastNameErrorMessage,
                                       MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                    textBoxLastName.BorderBrush = Brushes.Red;
                    lastNameErrorCounter++;
                }
                else if (error.PropertyName.Equals("Email") && emailErrorCounter == 0)
                {                    
                    new MessageBoxCustom(Properties.Langs.Lang.emailErrorMessage,
                                      MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                    textBoxEmail.BorderBrush = Brushes.Red;
                    emailErrorCounter++;
                }
            }
            stackPanelBlack.Visibility = Visibility.Collapsed;
            
            for (int i = 0; i < 5; i++)
            {
                if (usernameErrorCounter == 1 && passwordErrorCounter == 1 &&
                    nameErrorCounter == 1 && lastNameErrorCounter == 1 && emailErrorCounter == 1)
                {                    
                    break;
                }
                else if (usernameErrorCounter == 0)
                {
                    textBoxNickname.BorderBrush = Brushes.White;
                    usernameErrorCounter = 1;

                }
                else if (passwordErrorCounter == 0)
                {
                    textBoxPassword.BorderBrush = Brushes.White;
                    passwordErrorCounter = 1;

                }
                else if (nameErrorCounter == 0)
                {
                    textBoxName.BorderBrush = Brushes.White;
                    nameErrorCounter = 1;

                }
                else if (lastNameErrorCounter == 0)
                {
                    textBoxLastName.BorderBrush = Brushes.White;
                    lastNameErrorCounter = 1;

                }
                else if (emailErrorCounter == 0)
                {
                    textBoxEmail.BorderBrush = Brushes.White;
                    emailErrorCounter = 1;

                }
            }
                        
        }

        public void ClearFields()
        {
            textBoxName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxReEnterPassword.Clear();
            textBoxNickname.Clear();
        }

        private void PackIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LogIn logInWindow = new LogIn();
            logInWindow.Show();
            Close();

        }
    }

    public class FieldsValidator : AbstractValidator<Player>
    {

        private PlayerContext playerContext = new PlayerContext();

        public FieldsValidator()
        {            
            RuleFor(x => x.Nickname).NotNull()
                .NotEmpty()
                .MaximumLength(50)
                .Matches("^[0-9a-zA-ZÀ-ÿ\\u00f1\\u00d1]{1,}[0-9\\sa-zA-ZÀ-ÿ\\u00f1\\u00d1.:',_-]{0,}");

            RuleFor(x => x.Password).NotNull()
                .NotEmpty()
                .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[\\da-zA-ZÀ-ÿ\\u00f1\\u00d1$@$!%*?&#-.$($)$-$_]{8,16}$");

            RuleFor(x => x.Name).NotNull()
                .NotEmpty()
                .MaximumLength(50)
                .Matches("^[0-9a-zA-ZÀ-ÿ\\u00f1\\u00d1]{1,}[0-9\\sa-zA-ZÀ-ÿ\\u00f1\\u00d1.:',_-]{0,}");

            RuleFor(x => x.LastName).NotNull()
               .NotEmpty()
               .MaximumLength(50)
               .Matches("^[0-9a-zA-ZÀ-ÿ\\u00f1\\u00d1]{1,}[0-9\\sa-zA-ZÀ-ÿ\\u00f1\\u00d1.:',_-]{0,}");

            RuleFor(x => x.Email).NotNull()
               .NotEmpty()
               .MaximumLength(50)
               .Matches("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*(\\.[A-Za-z]{2,})$");

        }
    }


}
