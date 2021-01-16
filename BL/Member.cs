using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Member
    {
        public const int regular = 0;
        public const int moderator = 1;
        
        public Member(int id) : this(DBMember.GetUserById(id))
        {
        }

        private Member(DataRow dr)
        {
            if (dr == null) throw new InvalidOperationException();
            id = (int)dr["ID"];
            username = (string)dr["memberName"];
            password = (string)dr["memberPass"];
            rank = (int)dr["rank"];
            email = (string)dr["email"];
        }

        public int id { get; }
        public string username { get; }
        public string password { get; set; }
        public int rank { get; set; }
        public string email { get; set; }
        
        public static List<Member> AllUsers()
        {
            return (from DataRow row in DBMember.AllUsers().Rows select new Member(row)).ToList();
        }

        

        public static Member AuthUser(string username, string password)
        {
            return DBMember.Authenticate(username, password) ? new Member(DBMember.GetUserByName(username).Rows[0]) : null;
        }

        public static Member RegisterUser(int rank, string username, string password, string email)
        {
            if (DBMember.GetUserByName(username).Rows.Count != 0)
            {
                return null;
            }
            var id = DBMember.InsertUser(rank, username, password, email);
            return new Member(id);
        }

    }
}
