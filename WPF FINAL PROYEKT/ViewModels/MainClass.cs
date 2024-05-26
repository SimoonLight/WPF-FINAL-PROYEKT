using System.Windows;
using System.Windows.Controls;
using WPF_FINAL_PROYEKT.Models.Classes;
using WPF_FINAL_PROYEKT.Views.Pages;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class MainClass
    {
        public static Frame login_leftFrame { get; set; }
        public static Login_page login_left { get; set; }
        public static Frame login_rightFrame { get; set; }
        public static Frame signin_Frame { get; set; }
        public static Frame signup_Frame { get; set; }
        public static Frame menu_Frame { get; set; }
        public static Frame all_player_Frame { get; set; }
        public static Frame all_stadions_Frame { get; set; }
        public static Frame find_game_Frame { get; set; }
        public static Frame find_player_Frame { get; set; }
        public static Frame remove_find_player_Frame { get; set; }
        public static Frame add_stadion_Frame { get; set; }
        public static Frame remove_stadion_Frame { get; set; }
        //                     login_leftFrame, login_rightFrame, Sign_in_Frame, menu_Frame,all_player_Frame,          all_stadions_Frame,   find_game_Frame,    find_player_Frame  ,remove_find_player_Frame,add_stadion_Frame
        public MainClass(Frame leftFrame, Frame rightFrame, Frame signin_Frame, Frame signup_Frame,Frame menu_fr,Frame all_player_fr,Frame all_stadions_fr,Frame find_game_fr,Frame find_player_fr,Frame remove_find_player_fr,Frame add_stadion_fr,Frame remove_stadion_fr)
        {
            Stadion stadion1 = new Stadion("Tofiq Behramov1","Genclik");
            Stadion stadion2 = new Stadion("Tofiq Behramov2","Genclik");
            Stadion stadion3 = new Stadion("Tofiq Behramov3","Genclik");
            Stadion stadion4 = new Stadion("Tofiq Behramov4","Genclik");
            Stadion stadion5 = new Stadion("Tofiq Behramov5","Genclik");
            Stadion stadion6 = new Stadion("Tofiq Behramov6","Genclik");
            Stadion stadion7 = new Stadion("Tofiq Behramov7","Genclik");

            User user1 = new User("name","surname","username1","pass","email");
            User user2 = new User("name","surname","username2","pass","email");
            User user3 = new User("name","surname","username3","pass","email");
            User user4 = new User("name","surname","username4","pass","email");
            User user5 = new User("name","surname","username5","pass","email");

            Game game1 = new Game(stadion1, "15:00");
            Game game2 = new Game(stadion2, "10:00");
            Game game3 = new Game(stadion3, "17:00");
            Game game4 = new Game(stadion4, "19:00");
            Game game5 = new Game(stadion5, "20:00");
            Game game6 = new Game(stadion5, "21:00");
            Game game7 = new Game(stadion1, "22:00");

            user1.Add_station(stadion1);
            user2.Add_station(stadion2);
            user3.Add_station(stadion3);
            user4.Add_station(stadion4);
            user5.Add_station(stadion5);
            user5.Add_station(stadion6);
            user5.Add_station(stadion7);

            DataBase_.Add_user(user1);
            DataBase_.Add_user(user2);
            DataBase_.Add_user(user3);
            DataBase_.Add_user(user4);
            DataBase_.Add_user(user5);

            MainClass.login_leftFrame = leftFrame;
            MainClass.login_rightFrame = rightFrame;
            MainClass.signin_Frame = signin_Frame;
            MainClass.signup_Frame = signup_Frame;
            MainClass.menu_Frame = menu_fr;
            MainClass.all_player_Frame = all_player_fr;
            MainClass.all_stadions_Frame = all_stadions_fr;
            MainClass.find_game_Frame=find_game_fr;
            MainClass.find_player_Frame=find_player_fr;
            MainClass.remove_find_player_Frame=remove_find_player_fr;
            MainClass.add_stadion_Frame = add_stadion_fr;
            MainClass.remove_stadion_Frame= remove_stadion_fr;
            

            MainClass.login_leftFrame.Navigate(new Login_page(login_leftFrame,signin_Frame, signup_Frame));

            MainClass.login_rightFrame.Navigate(new Login_animation());

            MainClass.signin_Frame.Navigate(new SignIn_page(signin_Frame,menu_Frame));

           // MainClass.signup_Frame.Navigate(new SignUp(signup_Frame,login_left));

            MainClass.login_left=new Login_page(login_leftFrame,signin_Frame,signup_Frame);

            MainClass.menu_Frame.Navigate(new Menu_left());

            MainClass.all_player_Frame.Navigate(new All_players_page());

            MainClass.all_stadions_Frame.Navigate(new All_stadions_page());

            MainClass.find_game_Frame.Navigate(new Find_game_page());

            MainClass.find_player_Frame.Navigate(new Find_player_page());

            MainClass.remove_find_player_Frame.Navigate(new Remove_find_player_page());

            MainClass.add_stadion_Frame.Navigate(new Add_stadion_page());

            MainClass.remove_stadion_Frame.Navigate(new Remove_stadion_page());

        }
    }
}
