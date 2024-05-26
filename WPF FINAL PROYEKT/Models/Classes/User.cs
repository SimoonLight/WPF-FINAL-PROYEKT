using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FINAL_PROYEKT.Models.Classes
{
    public class User
    {
        public string user_name {  get; set; }
        public string user_surname {  get; set; }
        public string user_username {  get; set; }
        public string user_email {  get; set; }
        public string user_password {  get; set; }
        public List<Stadion> stations { get; set; }
        public List<Game> games { get; set; }

        public User(string name, string surname,  string username, string password, string user_email)
        {
            this.user_name = name;
            this.user_username = username;
            this.user_password = password;
            this.user_surname = surname;
            this.user_email = user_email;
            this.stations = new List<Stadion>();
        }

        public void Add_station(Stadion new_stadion)
        {
            stations.Add(new_stadion);
        }

        public void Remove_station(Stadion stadion)
        {
            stations.Remove(stadion);
        }
        
        public void Add_game(Game game)
        {
            games.Add(game);
        }

        public void Remove_game(Game game)
        {
            games.Remove(game);
        }


    }
}
