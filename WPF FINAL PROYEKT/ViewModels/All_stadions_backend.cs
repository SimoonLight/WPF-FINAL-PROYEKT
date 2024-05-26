using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_FINAL_PROYEKT.Models.Classes;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class All_stadions_backend : INotifyAutomatic
    {
        public List<Stadion> stadions { get; set; }

        public All_stadions_backend()
        {
            stadions = new List<Stadion>();
            for (int i = 0; i < DataBase_.users.Count; i++)
            {
                for (int j = 0; j < DataBase_.users[i].stations.Count; j++)
                {
                    if (DataBase_.users[i].stations[j] != null)
                    {
                        stadions.Add(DataBase_.users[i].stations[j]);
                    }
                }
            }
            if (DataBase_.User_working.stations.Count != 0)
            {

                for (int i = 0; i < DataBase_.User_working.stations.Count; i++)
                {
                    stadions.Add(DataBase_.User_working.stations[i]);
                }
            }
        }
    }
}
