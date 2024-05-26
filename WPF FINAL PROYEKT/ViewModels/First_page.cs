
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_FINAL_PROYEKT.Models.Commands;
using WPF_FINAL_PROYEKT.Views.Pages;
using System.Windows.Media;
using WPF_FINAL_PROYEKT.Models.Classes;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class First_page
    {

        public ICommand? Singin_command { get; set; }
        public ICommand? Signup_command { get; set; }
        public ICommand? Exit_command { get; set; }
        public Frame login_leftFrame { get; set; }
        public Frame signin_Frame { get; set; }
        public Frame signup_Frame { get; set; }

        public First_page(Frame leftFrame, Frame signinFrame, Frame signup_Frame)
        {
            login_leftFrame = leftFrame;
            signin_Frame = signinFrame;
            this.signup_Frame = signup_Frame;

            Singin_command = new RelayCommand(Signin_, isSignin);
            Signup_command = new RelayCommand(Signup_, isSignup);
            Exit_command = new RelayCommand(Exit_, isExit);
        }

        public bool isSignin(object? p)
        {
            return true;
        }
        public bool isSignup(object? p)
        {
            return true;
        }
        public bool isExit(object? p)
        {
            return true;
        }

        public void Signin_(object? p)
        {
            var loginPage = new Login_page(login_leftFrame,signin_Frame, signup_Frame);
            var signInPage = new SignIn_page(MainClass.signin_Frame,MainClass.menu_Frame);

            login_leftFrame.Navigate(loginPage);
            signin_Frame.Navigate(signInPage);
            loginPage.Visibility = Visibility.Collapsed;
            signin_Frame.Visibility = Visibility.Visible;
        }
        public void Signup_(object? p)
        {
            var loginPage = new Login_page(login_leftFrame, signin_Frame, signup_Frame);
            var signUpPage = new SignUp(signup_Frame,login_leftFrame);

            login_leftFrame.Navigate(loginPage);
            signup_Frame.Navigate(signUpPage);
            loginPage.Visibility = Visibility.Collapsed;
            signup_Frame.Visibility = Visibility.Visible;
            //
        }
        public void Exit_(object? p)
        {
            Application.Current.Shutdown();
        }
    }
}
