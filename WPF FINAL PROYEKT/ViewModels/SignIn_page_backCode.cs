using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WPF_FINAL_PROYEKT.Models.Commands;
using WPF_FINAL_PROYEKT.Views.Pages;
using WPF_FINAL_PROYEKT.Models.Classes;
using System.Windows.Controls;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class SignIn_page_backCode : INotifyAutomatic
    {
        private Frame _signInPage { get; set; }
        private Frame _menuPage { get; set; }

        private string username_singin_fp = "";

        public string Username_singin_fp
        {
            get { return username_singin_fp; }
            set
            {
                username_singin_fp = value;
                OnPropertyChanged();
            }
        }

        private string password_singin_fp = "";

        public string Password_singin_fp
        {
            get { return password_singin_fp; }
            set
            {
                password_singin_fp = value;
                OnPropertyChanged();
            }
        }


        public ICommand? backSignIn_command { get; set; }
        public ICommand? loginSignIn_command { get; set; }

        public SignIn_page_backCode(Frame signInPage, Frame menuPage)
        {

            backSignIn_command = new RelayCommand(Back_, isBack);

            loginSignIn_command = new RelayCommand(Lognin_, isLognin);
            _signInPage = signInPage;
            _menuPage = menuPage;
        }

        public bool isLognin(object? p)
        {
            return true;
        }

        public void Lognin_(object? p)
        {
            //for (int i = 0; i < DataBase_.users.Count; i++)
            //{
            //    if (DataBase_.users[i].user_username == Username_singin_fp &&
            //        DataBase_.users[i].user_password == Password_singin_fp)
            //    {
            //        DataBase_.Still_user(DataBase_.users[i]);
            //        _signInPage.Visibility = Visibility.Hidden;
            //        _menuPage.Visibility = Visibility.Visible;

            //        return;
            //    }
            //}
            //MessageBox.Show("have error");

            var menuPage = new Menu_left();
            _menuPage.Visibility = Visibility.Visible;
            _menuPage.Navigate(menuPage);

            var signInPage = new SignIn_page(MainClass.signin_Frame,MainClass.menu_Frame);
            _signInPage.Navigate(signInPage);
            _signInPage.Visibility = Visibility.Collapsed;



        }

        public bool isBack(object? p)
        {
            return true;
        }

        public void Back_(object? p)
        {
            var mainPage = new Login_page(MainClass.login_leftFrame,MainClass.signin_Frame,MainClass.signup_Frame);
            _menuPage.Visibility = Visibility.Visible;
            _menuPage.Navigate(mainPage);

            _signInPage.Visibility = Visibility.Hidden;
        }




    }
}
