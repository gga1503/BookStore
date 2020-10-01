using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GracielaBookStore.Models;

namespace GracielaBookStore.Factory
{
    public class UserFactory
    {
        public static User UserLogin(string username, string password)
        {
            User loginData = new User();

            loginData.Username = username;
            loginData.Password = password;

            return loginData;
        }

        public static User InsertUser(string username, string email, string password, string name, short gender, int phoneNumber, string address)
        {
            User userData = new User();

            userData.RoleID = 2;
            userData.Username = username;
            userData.Email = email;
            userData.Password = password;
            userData.Name = name;
            userData.Gender = gender;
            userData.PhoneNumber = phoneNumber;
            userData.Address = address;

            return userData;
        }

        public static User BanUser(int userID, bool banned)
        {
            var userData = new User()
            {
                UserID = userID,
                Banned = banned
            };

            return userData;
        }

        public static User PromoteUser(int userID, short roleID)
        {
            var userData = new User()
            {
                UserID = userID,
                RoleID = roleID
            };

            return userData;
        }

        public static User DeleteUser(int userID)
        {
            var userData = new User()
            {
                UserID = userID
            };

            return userData;
        }

        public static User GetProfile(int userID)
        {
            var userData = new User()
            {
                UserID = userID,
            };

            return userData;
        }

        public static User UpdateProfile(string username, string name, short gender, int phoneNumber, string address)
        {
            var userData = new User()
            {
                Username = username,
                Name = name,
                Gender = gender,
                PhoneNumber = phoneNumber,
                Address = address
            };

            return userData;
        }

        public static User ChangePassword(string username, string password)
        {
            var userData = new User()
            {
                Username = username,
                Password = password
            };

            return userData;
        }
    }
}