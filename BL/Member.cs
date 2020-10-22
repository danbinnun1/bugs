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
        public static int regular = 0;
        public static int moderator = 0;
        
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
        }

        public int id { get; }
        public string username { get; }
        public string password { get; set; }
        public int rank { get; set; }
        
        public static List<Member> AllUsers()
        {
            return (from DataRow row in DBMember.AllUsers().Rows select new Member(row)).ToList();
        }

        

        public static Member AuthUser(string username, string password)
        {
            return DBMember.Authenticate(username, password) ? new Member(DBMember.GetUserByName(username)) : null;
        }

        public static Member RegisterUser(int rank, string username, string password)
        {
            var id = DBMember.InsertUser(rank, username, password);
            return new Member(id);
        }

    }
}
