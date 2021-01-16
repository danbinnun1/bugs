using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBMember
    {
        /// <summary>
        /// Retrieves a list of all users that are signed up
        /// </summary>
        /// <returns>DataTable of all users</returns>
        public static DataTable AllUsers()
        {
            return DalHelper.AllFromTable("members");
        }

        /// <summary>
        /// Gets a user by id
        /// </summary>
        /// <param name="user">id of user</param>
        /// <returns>DataRow of user data</returns>
        public static DataRow GetUserById(int user)
        {
            return DalHelper.GetRowById(user, "members");
        }


        /// <summary>
        /// Gets a user by username
        /// </summary>
        /// <param name="username">username of user</param>
        /// <returns>DataRow of user data</returns>
        public static DataTable GetUserByName(string username)
        {
            return DalHelper.Select("SELECT * FROM members WHERE memberName = '" + username + "';");
        }

        /// <summary>
        /// Method that checks if a user and password are valid for authentication 
        /// </summary>
        /// <param name="username">user</param>
        /// <param name="password">password</param>
        /// <returns>if the username password combination is valid</returns>
        public static bool Authenticate(string username, string password)
        {
            var tb = DalHelper.Select("SELECT * FROM members WHERE memberName = '" + username + "' AND memberPass='"+password+"';");

            return tb.Rows.Count != 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static int InsertUser(int rank, string username, string password, string email)
        {
            return DalHelper.Insert(
                "INSERT INTO members" +
                "(memberName, memberPass, rank, email)" +
                $"VALUES('{username}','{password}', {rank}, '{email}')");
        }
    }
}
