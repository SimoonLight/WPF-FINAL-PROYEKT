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
    /// Interaction logic for All_stadions_page.xaml
    /// </summary>
    public partial class All_stadions_page : Page
    {
        public All_stadions_page()
        {
            InitializeComponent();
            DataContext = new All_stadions_backend();
        }
    }
}
