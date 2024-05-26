using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF_FINAL_PROYEKT.Models.Classes;

namespace WPF_FINAL_PROYEKT.Models.Classes
{
    public static class File_works
    {

        public static void Write_User()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(DataBase_.users, options);

            File.WriteAllText("Users.json", jsonString);
        }
        public static void ReadUsersFromJson()
        {
            string filePath = "Users.json";

            if (!File.Exists(filePath))
            {
                string defaultJsonString = "[]";
                File.WriteAllText(filePath, defaultJsonString);
            }

            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };

                string jsonString = File.ReadAllText(filePath);
                List<User> _users = JsonSerializer.Deserialize<List<User>>(jsonString, options);
                DataBase_.users = _users;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Kullanıcılar yüklenirken bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
