using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FINAL_PROYEKT.Models.Classes
{
    public static class DataBase_
    {
        public static List<User> users =new List<User>();

        public static User User_working=new User("","","","","");

        public static void Add_user(User new_user)
        {
            File_works.ReadUsersFromJson();
            users.Add(new_user);
            File_works.Write_User();
        }
        public static void Remove_user(User user)
        {
            File_works.ReadUsersFromJson();
            users.Remove(user);
            File_works.Write_User();
        }

        public static void Still_user(User user)
        {
            User_working = user;
        }

    }
}
