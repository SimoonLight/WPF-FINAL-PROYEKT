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
    /// <summary>
    /// Interaction logic for SignIn_page.xaml
    /// </summary>
    public partial class SignIn_page : Page
    {
        public SignIn_page(Frame Sign_in_Frame, Frame menu_Frame)
        {
            InitializeComponent();
            DataContext = new SignIn_page_backCode(Sign_in_Frame, menu_Frame);
        }
    }
}
