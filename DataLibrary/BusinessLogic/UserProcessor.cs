﻿using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser
            (string firstName, string lastName, string email, string password, bool newsletter)
        {
            UserModel data = new UserModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Newsletter = newsletter
            };

            string sql = @"insert into dbo.Users(FirstName, LastName, Email, Password, Newsletter)
                values (@FirstName, @LastName, @Email, @Password, @Newsletter);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static void AddUserID()
        {
            string sql = "CREATE TRIGGER incrementValue ON Test FOR Insert AS Update Test set columnvalue = columnvalue + 1 where id in (select id from inserted) GO";
        }

        public static void UniqueEmail()
        {
            
        }

        public static List<UserModel> LoadUsers()
        {
            string sql = @"select * from dbo.Users;";
            return SqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}
