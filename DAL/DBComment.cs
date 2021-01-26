using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBComment
    {
        
        public static int Insert(int member, string comment, int post, string date)
        {
            return DalHelper.Insert(
                "INSERT INTO comments" +
                "([member], [comment], [post], [commentDate])" +
                $"VALUES({member},'{comment}', {post}, '{date}')");
        }
        public static DataTable GetByPost(int post)
        {
            return DalHelper.Select("SELECT * FROM comments WHERE [post]=" + post + ";");
        }
    }
}
