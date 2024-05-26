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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_FINAL_PROYEKT.ViewModels;

namespace WPF_FINAL_PROYEKT.Views.Pages
{
    public partial class Main_page : Page
    {
        public Main_page()
        {
            InitializeComponent();
            DataContext = new MainClass(login_leftFrame, login_rightFrame, Sign_in_Frame, Sign_up_Frame, menu_Frame,all_player_Frame,all_stadions_Frame,find_game_Frame,find_player_Frame,remove_find_player_Frame,add_stadion_Frame, remove_stadion_Frame);
        }
    }
}
