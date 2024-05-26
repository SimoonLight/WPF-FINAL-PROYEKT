using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_FINAL_PROYEKT.Models.Classes;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class All_players_backend : INotifyAutomatic
    {
        public List<User> Users { get; set; }

        public All_players_backend()
        {
            Users = new List<User>();
            Users = DataBase_.users;
        }
    }
}
