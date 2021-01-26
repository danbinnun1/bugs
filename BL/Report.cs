using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Report
    {
        public int ID { get; set; }
        public string description { get; set; }
        public int reporterID { get; set; }
        public string date { get; set; }
        public int status { get; set; }
        public string response { get; set; }
        public string image { get; set; }
        public string statusMessage
        {
            get
            {
                switch (status)
                {
                    case 0:
                        return "approved";
                    case 1:
                        return "denied";
                    case 2:
                        return "in process";
                    default:
                        return "";
                }
            }
        }

        public bool canBeAppealed
        {
            get
            {
                return status == 1;
            }
        }
        public string StartOfContent
        {
            get
            {
                return description.Substring(0, Math.Min(20, description.Length)) + "...";
            }
        }

        public Report(int iD, string description, int reporterID, string date, int status, string response, string image)
        {
            ID = iD;
            this.description = description;
            this.reporterID = reporterID;
            this.date = date;
            this.status = status;
            this.response = response;
            this.image = image;
        }

        public Report(DataRow row)
        {
            ID = (int)row["ID"];
            description = (string)row["description"];
            reporterID = (int)row["reporter"];
            date = (string)row["reportdate"];
            status = (int)row["status"];
            response = (string)row["moderatorResponse"];
            image = (string)row["image"];
        }

        public static List<Report> PendingReports()
        {
            return (from DataRow row in DBReport.ReportsByStatus(Status.pending).Rows select new Report(row)).ToList();
        }
        public static List<Report> AcceptedReports()
        {
            return (from DataRow row in DBReport.ReportsByStatus(Status.approved).Rows select new Report(row)).ToList();
        }

        public void Insert()
        {
            ID = DBReport.AddReport(description, reporterID, date, response, image, status);
        }
        public static void update(bool approved, string response, int id)
        {
            int status;
            if (approved)
            {
                status = Status.approved;
            }
            else
            {
                status = Status.denied;
            }
            DBReport.Update(response, status, id);
        }
        public void updateImage(string image)
        {
            DBReport.UpdateImage(ID, image);
            this.image = image;
        }
        public Report(int id) : this(DBReport.reportsById(id).Rows[0])
        { }
    }
}
