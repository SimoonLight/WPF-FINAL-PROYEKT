using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_FINAL_PROYEKT.Models.Classes;
using WPF_FINAL_PROYEKT.Models.Commands;

namespace WPF_FINAL_PROYEKT.ViewModels
{
    public class Add_stadion_backend : INotifyAutomatic
    {
		private string st_name;

		public string St_name
		{
			get { return st_name; }
            set
            {
                st_name = value;
                OnPropertyChanged();
            }
        }
        
        private string st_adres;

		public string St_adres
        {
			get { return st_adres; }
            set
            {
                st_adres = value;
                OnPropertyChanged();
            }
        }

        public ICommand? add_st {  get; set; }


        public Add_stadion_backend()
        {
            add_st = new RelayCommand(Name_, isName);
        }

        public bool isName(object? p)
        {
            return true;
        }

        public void Name_(object? p)
        {
            if (St_adres != "" && St_name != "")
            {
                Stadion stadion = new Stadion(St_name,St_adres);
                if (DataBase_.User_working != null)
                {

                DataBase_.User_working.Add_station(stadion);
                }
            }
        }

    }
}
