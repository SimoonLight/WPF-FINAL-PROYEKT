using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_FINAL_PROYEKT.Models.Classes
{
    public class Stadion
    {
        public string name_station { get; set; }
        public string adres_station {  get; set; }
        //public Image image_station {  get; set; }

        public Stadion(string name_station, string adres_station)
        {
            this.name_station = name_station;
            this.adres_station = adres_station;
            //this.image_station = image_station;
        }
    }
}
