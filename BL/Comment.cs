using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BL
{
    public class Comment
    {
        public static int commentToComment = 0;
        public static int commentToPost = 1;
        public int ID { get; set; }
        public Member Reporter { get; set; }
        public string Content { get; set; }
        public Report Post { get; set; }
        public string date { get; set; }
        public string ReporterName
        {
            get
            {
                return Reporter.username;
            }
        }

        public Comment(Member reporter, string content, Report post, string date)
        {
            Reporter = reporter;
            Content = content;
            Post = post;
            this.date = date;
        }
        private Comment(DataRow row)
        {
            Reporter = new Member((int)row["member"]);
            Content = (string)row["comment"];
            Post = new Report((int)row["post"]);
            date = (string)row["commentdate"];
            ID = (int)row["ID"];
        }
        public void Insert()
        {
            ID = DBComment.Insert(Reporter.id, Content, Post.ID, date);
        }
        public static List<Comment> GetByPost(Report post)
        {
            return (from DataRow row in DBComment.GetByPost(post.ID).Rows select new Comment(row)).ToList();
        }
    }
}
