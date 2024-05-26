using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using WPF_FINAL_PROYEKT.Models.Commands;
using WPF_FINAL_PROYEKT.Views.Pages;
using WPF_FINAL_PROYEKT.Models.Classes;
using System.Security;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class SignUp_page_backCode : INotifyAutomatic
    {
        public int numberofMail;

        private Frame _signUpPage { get; set; }
        private Frame _logInPage { get; set; }

        private string username_signUp;
        public string Username_signUp
        {
            get { return username_signUp; }
            set
            {
                username_signUp = value;
                OnPropertyChanged();
            }
        }

        private string name_signUp;
        public string Name_signUp
        {
            get { return name_signUp; }
            set
            {
                name_signUp = value;
                OnPropertyChanged();
            }
        }

        private string surname_signUp;
        public string Surname_signUp
        {
            get { return surname_signUp; }
            set
            {
                surname_signUp = value;
                OnPropertyChanged();
            }
        }

        private string email_signUp;
        public string Email_signUp
        {
            get { return email_signUp; }
            set
            {
                email_signUp = value;
                OnPropertyChanged();
            }
        }

        private string password_signUp;
        public string Password_signUp
        {
            get { return password_signUp; }
            set
            {
                password_signUp = value;
                OnPropertyChanged();
            }
        }


        private string email_code_signUp;
        public string Email_code_signUp
        {
            get { return email_code_signUp; }
            set
            {
                email_code_signUp = value;
                OnPropertyChanged();
            }
        }


        private string btn_;

        public string Btn_
        {
            get { return btn_; }
            set { btn_ = value; }
        }


        public ICommand? backSignUp_command { get; set; }
        public ICommand? loginSignUp_command { get; set; }
        public ICommand? applySignUp_command { get; set; }

        public SignUp_page_backCode(Frame signUpPage, Frame logInPage)
        {
            Btn_ = "Log in";

            backSignUp_command = new RelayCommand(Back_, isBack);
            loginSignUp_command = new RelayCommand(Lognin_, isLognin);
            applySignUp_command = new RelayCommand(Lognin_, isApply);

            _signUpPage = signUpPage;
            _logInPage = logInPage;
        }

        public bool isApply(object? p)
        {
            return true;
        }

        public void Apply_(object? p)
        {
            if (Email_code_signUp.ToString() != "")
            {
                if (email_code_signUp.ToString() == numberofMail.ToString())
                {
                    User new_user = new User(Name_signUp, Surname_signUp, Username_signUp, Password_signUp, Email_signUp);
                    DataBase_.Add_user(new_user);
                    _signUpPage.Visibility = Visibility.Hidden;
                    MessageBox.Show("Succesfully");
                }
                else
                {
                    MessageBox.Show("Wrong code");
                }
            }
            else
            {

                MessageBox.Show("Enter code");
            }
        }

        public bool isLognin(object? p)
        {
            return true;
        }

        public void Lognin_(object? p)
        {
            if (Username_signUp != null && Name_signUp != null && Surname_signUp != null && Email_signUp != null && Password_signUp != null)
            {
                if (Btn_ == "Log in")
                {
                    Btn_ = "Apply";

                    numberofMail = Mail_works.SendEmail(Email_signUp.ToString());
                    if (numberofMail == -1)
                    {
                        MessageBox.Show("You have a problem about Email address");
                    }
                }
                else
                {
                    Btn_ = "Log in"; 
                    if (Email_code_signUp.ToString() != "")
                    {
                        if (email_code_signUp.ToString() == numberofMail.ToString())
                        {
                            User new_user = new User(Name_signUp, Surname_signUp, Username_signUp, Password_signUp, Email_signUp);
                            var mainPage = new Login_page(MainClass.login_leftFrame, MainClass.signin_Frame, MainClass.signup_Frame);
                            _signUpPage.Visibility = Visibility.Hidden;
                            _logInPage.Visibility = Visibility.Visible;
                            _logInPage.Navigate(mainPage);
                            DataBase_.Add_user(new_user);
                            MessageBox.Show("Succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Wrong code");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Enter code");
                    }
                }
            }

        }

        public bool isBack(object? p)
        {
            return true;
        }

        public void Back_(object? p)
        {
            var mainPage = new Login_page(MainClass.login_leftFrame, MainClass.signin_Frame, MainClass.signup_Frame);
            _signUpPage.Visibility = Visibility.Hidden;
            _logInPage.Visibility = Visibility.Visible;
            _logInPage.Navigate(mainPage);

        }

    }
}
