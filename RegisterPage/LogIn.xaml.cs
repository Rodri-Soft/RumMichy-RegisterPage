using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RegisterPage.Models;

namespace RegisterPage
{
    
    public partial class LogIn : Window
    {
        private PlayerContext playerContext = new PlayerContext();
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxLanguage.SelectedIndex == 0)
            {
                Properties.Settings.Default.languageCode = "en-US";                               
            }
            else
            {
                Properties.Settings.Default.languageCode = "es-MX";
            }
            Properties.Settings.Default.Save();

            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
      
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow registerPage = new MainWindow();
            registerPage.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var nicknameExist = GetUniqueNickname();
                

            if (nicknameExist.Count() != 0)
            {

                var encryptedPassword = Encrypt.GetSHA256(passwordBoxLogInPassword.Password);

                var databasePlayer = GetUniqueNickname();

                Player checkPlayer = databasePlayer.First();

                if (checkPlayer.Password == encryptedPassword)
                {
                    stackPanelBlack.Visibility = Visibility.Visible;
                    new MessageBoxCustom("Estas logeado",
                                      MessageType.Success, MessageButtons.Ok, false).ShowDialog();
                    stackPanelBlack.Visibility = Visibility.Collapsed;
                }
                else
                {
                    stackPanelBlack.Visibility = Visibility.Visible;                    
                    new MessageBoxCustom(Properties.Langs.Lang.failedLogIn,
                                      MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                    stackPanelBlack.Visibility = Visibility.Collapsed;

                }
            }
            else
            {
                stackPanelBlack.Visibility = Visibility.Visible;                
                new MessageBoxCustom(Properties.Langs.Lang.failedLogIn,
                                      MessageType.Error, MessageButtons.Ok, false).ShowDialog();
                stackPanelBlack.Visibility = Visibility.Collapsed;
            }
        }      

        public System.Data.Entity.Infrastructure.DbRawSqlQuery<Player> GetUniqueNickname()
        {
            System.Data.Entity.Infrastructure.DbRawSqlQuery<Player> nicknameExist =
                    playerContext.Database.SqlQuery<Player>("SELECT * FROM Player WHERE Nickname = @nickname",
                    new SqlParameter("@nickname", textBoxLogInNickName.Text));

            return nicknameExist;

        } 
    }

}
