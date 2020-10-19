using DataLibrary.DataAccess;
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
        public static int CreateUser(string firstName, string lastName, string password, string email, int userType, bool newsletter)
        {
            UserModel data = new UserModel
            {
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                Email = email,
                UserType = userType,
                Newsletter = newsletter
            };

            string sql = @"insert into dbo.User(FirstName, LastName, Email, Password, UserType, Newsletter)
                values (@FirstName, @LastName, @Email, @Password, @UserType, @Newsletter);";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<UserModel> LoadUsers()
        {
            string sql = @"select *
                            from dbo.Users;";
            return SQLDataAccess.LoadData<UserModel>(sql);
        }
    }
}
