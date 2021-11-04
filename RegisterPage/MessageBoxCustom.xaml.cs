using System;
using System.Collections.Generic;
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
using RegisterPage.Models;

namespace RegisterPage
{
    public partial class MessageBoxCustom : Window
    {
        private static string confirmationCode="";
        private bool dialogResult = false;

        public MessageBoxCustom() { }

        public string GetCode()
        {
            return confirmationCode;
        }

        public bool GetDialog()
        {
            return dialogResult;
        } 

        public MessageBoxCustom(string message, MessageType type, MessageButtons buttons, bool longMessage)
        {
            InitializeComponent();
            if (longMessage)
                textBoxMessage.FontSize = 16;

            textBoxMessage.Text = message;
            
            switch (type)
            {

                case MessageType.Info:
                    txtTitle.Text = "Info";
                    imageMichyOk.Visibility = Visibility.Visible;
                    break;

                case MessageType.Confirmation:
                    txtTitle.Text = "Confirmation";
                    imageMichyOk.Visibility = Visibility.Visible;
                    break;

                case MessageType.Success:                    
                    txtTitle.Text = "Success";
                    imageMichyOk.Visibility = Visibility.Visible;
                    break;

                case MessageType.Warning:
                    txtTitle.Text = "Warning";
                    imageInvalidMichy.Visibility = Visibility.Visible;
                    break;

                case MessageType.Error:                    
                    txtTitle.Text = "Error";
                    imageInvalidMichy.Visibility = Visibility.Visible;
                    break;

                case MessageType.Submit:                                           
                    txtTitle.Text = "Submit";


                    Properties.Settings.Default.languageCode = "en-US";
                    imageWaitMichy.Visibility = Visibility.Visible;
                    break;

            }

            switch (buttons)
            {               
                case MessageButtons.Ok:                    
                    buttonOk.Visibility = Visibility.Visible;
                    buttonCancel.Visibility = Visibility.Collapsed;                    
                    buttonSubmit.Visibility = Visibility.Collapsed;
                    buttonAccept.Visibility = Visibility.Collapsed;
                    break;

                case MessageButtons.Submit:                   
                    textBoxConfirmationCode.Visibility = Visibility.Visible;
                    buttonSubmit.Visibility = Visibility.Visible;
                    buttonOk.Visibility = Visibility.Collapsed;
                    buttonCancel.Visibility = Visibility.Collapsed;                    
                    buttonAccept.Visibility = Visibility.Collapsed;
                    break;

                case MessageButtons.AcceptCancel:
                    buttonAccept.Visibility = Visibility.Visible;
                    buttonOk.Visibility = Visibility.Collapsed;                    
                    buttonSubmit.Visibility = Visibility.Collapsed;
                    break;

            }            
        }                  

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            dialogResult = true;           
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            dialogResult = true;
            confirmationCode = textBoxConfirmationCode.Text;
            this.Close();
            
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            dialogResult = true;            
            this.Close();
        }
       
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            dialogResult = false;           
            this.Close();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            dialogResult = false;           
            this.Close();
        }              
    }

    public enum MessageType
    {
        Info,
        Confirmation,
        Success,
        Warning,
        Error,
        Submit,
    }
    public enum MessageButtons
    {                
        Ok,
        Submit,
        AcceptCancel,
    }
}
