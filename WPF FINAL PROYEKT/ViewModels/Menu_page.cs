using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_FINAL_PROYEKT.Models.Commands;
using WPF_FINAL_PROYEKT.Models.Classes;
using System.Windows;
using WPF_FINAL_PROYEKT.Views.Pages;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class Menu_page
    {
        public ICommand? all_player_command {  get; set; }
        public ICommand? all_stadions_command { get; set; }
        public ICommand? find_game_command { get; set; }
        public ICommand? find_player_command { get; set; }
        public ICommand? stop_search_player_command { get; set; }
        public ICommand? add_stadion_command { get; set; }
        public ICommand? remove_stadion_command { get; set; }
        public ICommand? log_out_command { get; set; }

        public Menu_page()
        {
            all_player_command=new RelayCommand(all_players_, isok);
            all_stadions_command = new RelayCommand(all_stadions_, isok);
            find_game_command = new RelayCommand(find_game_, isok);
            find_player_command = new RelayCommand(find_player_, isok);
            stop_search_player_command = new RelayCommand(stop_search_player_, isok);
            add_stadion_command = new RelayCommand(add_stadion_, isok);
            remove_stadion_command = new RelayCommand(remove_stadion_, isok);
            log_out_command = new RelayCommand(LogOut_, isok);
        }

        public bool isok(object? p)
        {
            return true;
        }

        public void all_players_(object? p)
        {
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Visible;

            MainClass.login_leftFrame.Visibility = Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = Visibility.Hidden; 
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.add_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
        }
        
        public void all_stadions_(object? p)
        {
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Visible;

            MainClass.login_leftFrame.Visibility = Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = Visibility.Hidden;
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.add_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
        }

        public void find_game_(object? p)
        {
            MainClass.login_leftFrame.Visibility = Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = Visibility.Hidden;
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Visible;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.add_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
        }
        
        public void find_player_(object? p)
        {
            MainClass.login_leftFrame.Visibility = Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = Visibility.Hidden;
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Visible;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.add_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
        }
        
        public void stop_search_player_(object? p)
        {
            MainClass.login_leftFrame.Visibility = Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = Visibility.Hidden;
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Visible;
            MainClass.add_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
        }
        
        public void add_stadion_(object? p)
        {
            MainClass.login_leftFrame.Visibility = Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = Visibility.Hidden;
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.add_stadion_Frame.Visibility = System.Windows.Visibility.Visible;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
        }
        
        public void remove_stadion_(object? p)
        {
            MainClass.login_leftFrame.Visibility = Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = Visibility.Hidden;
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Visible;
        }

        public void LogOut_(object? p)
        {
            MainClass.menu_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.login_leftFrame.Visibility = Visibility.Visible;

            MainClass.add_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.all_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.all_stadions_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_game_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_find_player_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.remove_stadion_Frame.Visibility = System.Windows.Visibility.Hidden;
            MainClass.login_rightFrame.Visibility = System.Windows.Visibility.Visible;

            var loginPage = new Login_page(MainClass.login_leftFrame, MainClass.signin_Frame, MainClass.signup_Frame);
            MainClass.login_leftFrame.Navigate(loginPage);
            MainClass.signin_Frame.Visibility = Visibility.Visible;
        }


    }
}
