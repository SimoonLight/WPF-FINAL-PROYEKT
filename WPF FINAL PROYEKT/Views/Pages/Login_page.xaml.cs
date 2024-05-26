using System.Windows.Controls;
using WPF_FINAL_PROYEKT.ViewModels;

namespace WPF_FINAL_PROYEKT.Views.Pages
{
    /// <summary>
    /// Interaction logic for Login_page.xaml
    /// </summary>
    public partial class Login_page : Page
    {
        public Login_page(Frame leftFrame, Frame signinFrame, Frame signupFrame)
        {
            InitializeComponent();
            DataContext = new First_page(leftFrame, signinFrame, signupFrame);

        }
    }
}