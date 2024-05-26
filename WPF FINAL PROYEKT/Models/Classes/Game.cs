using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FINAL_PROYEKT.Models.Classes
{
    public class Game
    {
        public Stadion _Stadion { get; set; }
        public string _Time { get; set; }

        public Game(Stadion stadion, string time) 
        {
            this._Stadion = stadion;
            this._Time = time;
        }
    }
}
