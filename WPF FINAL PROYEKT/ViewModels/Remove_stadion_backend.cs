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
    public class Remove_stadion_backend : INotifyAutomatic
    {
        public List<Stadion> stadions { get; set; }

        private Stadion _selectedStadion;

        public Stadion SelectedStadion
        {
            get { return _selectedStadion; }
            set
            {
                _selectedStadion = value;
                OnPropertyChanged();
            }
        }

        private ICommand _removeStadionCommand;

        public ICommand RemoveStadionCommand
        {
            get
            {
                if (_removeStadionCommand == null)
                {
                    _removeStadionCommand = new RelayCommand(param => RemoveStadion(param),
                                                              param => CanRemoveStadion());
                }
                return _removeStadionCommand;
            }
        }

        private bool CanRemoveStadion()
        {
            return true;
        }

        private void RemoveStadion(object param)
        {
            if (SelectedStadion != null)
            {
                stadions.Remove(SelectedStadion);
            }
        }

        public Remove_stadion_backend()
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
