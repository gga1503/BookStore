using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using GracielaBookStore.Models;

namespace GracielaBookStore.Repository
{
    public class UserRepository
    {
        static DataTable dt = new DataTable();

        public static User UserLogin(User loginData)
        {
            var query = $"SELECT * FROM [User] WHERE [Username] = '{loginData.Username}' AND [Password] = '{loginData.Password}'";

            dt = DbManager.Get(query);

            if (dt.Rows.Count <= 0) return null;
            var response = new User()
            {
                Username = dt.Rows[0]["Username"].ToString(),
                RoleID = Convert.ToInt16(dt.Rows[0]["RoleID"].ToString()),
                Banned = Convert.ToBoolean(dt.Rows[0]["Banned"].ToString())
            };

            return response;
        }

        public static void InsertUser(User userData)
        {
            var query = "INSERT INTO [User]([RoleID], [Username], [Email], [Name], [Password], [Gender], [PhoneNumber], [Address]) VALUES" +
                        $"({userData.RoleID}, '{userData.Username}', '{userData.Email}', '{userData.Name}', '{userData.Password}', {userData.Gender}, {userData.PhoneNumber}, '{userData.Address}')";

            DbManager.Execute(query);
        }

        public static List<User> GetAllUsers()
        {
            string query = $"SELECT * FROM [User]";

            dt = DbManager.Get(query);

            if (dt.Rows.Count <= 0) return null;
            var users = new List<User>();

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var user = new User()
                {
                    UserID = Convert.ToInt16(dt.Rows[i]["UserID"]),
                    RoleID = Convert.ToInt16(dt.Rows[i]["RoleID"]),
                    Username = dt.Rows[i]["Username"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Name = dt.Rows[i]["Name"].ToString(),
                    Password = dt.Rows[i]["Password"].ToString(),
                    Gender = Convert.ToInt16(dt.Rows[i]["Gender"]),
                    PhoneNumber = Convert.ToInt32(dt.Rows[i]["PhoneNumber"]),
                    Address = dt.Rows[i]["Address"].ToString(),
                    Banned = Convert.ToBoolean(dt.Rows[i]["Banned"])
                };
                users.Add(user);
            }
            return users;
        }

        public static void BanUser(User userData)
        {
            var query = $"UPDATE [User] SET [Banned] = {userData.Banned} WHERE[UserID] = {userData.UserID}";
            DbManager.Execute(query);
        }

        public static void PromoteUser(User userData)
        {
            var query = $"UPDATE [User] SET [Banned] = {userData.Banned} WHERE[UserID] = {userData.RoleID}";
            DbManager.Execute(query);
        }

        public static void DeleteUser(User userData)
        {
            var query = $"DELETE [User] WHERE [UserID] = {userData.UserID};";
            DbManager.Execute(query);
        }

        public static User GetProfile(User userData)
        {
            var query = $"SELECT * FROM [User] WHERE [UserID] = '{userData.UserID}'";

            dt = DbManager.Get(query);

            if (dt.Rows.Count <= 0) return null;

            var response = new User()
            {
                UserID = Convert.ToInt32(dt.Rows[0]["UserID"]),
                RoleID = Convert.ToInt32(dt.Rows[0]["RoleID"]),
                Username = dt.Rows[0]["Username"].ToString(),
                Email = dt.Rows[0]["Email"].ToString(),
                Name = dt.Rows[0]["Name"].ToString(),
                Password = dt.Rows[0]["Password"].ToString(),
                Gender = Convert.ToInt16(dt.Rows[0]["Gender"]),
                PhoneNumber = Convert.ToInt32(dt.Rows[0]["PhoneNumber"]),
                Address = dt.Rows[0]["Address"].ToString(),
                Banned = Convert.ToBoolean(dt.Rows[0]["Banned"])
            };

            return response;
        }

        public static void UpdateUser(User userData)
        {
            var query = $"UPDATE [User] SET [Name] = '{userData.Name}', [Gender] = {userData.Gender}, [PhoneNumber] = {userData.PhoneNumber}, [Address] = '{userData.Address}' WHERE [Username] = {userData.Username};";
            DbManager.Execute(query);
        }

        public static void ChangePassword(User userData)
        {
            var query = $"UPDATE [User] SET [Password] = '{userData.Password}' WHERE [Username] = {userData.Username};";
            DbManager.Execute(query);
        }
    }
}