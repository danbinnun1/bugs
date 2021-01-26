using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BL
{
    public class Appeal
    {
        public int ID { get; set; }
        public Report AppealedReport { get; set; }
        public string Reason { get; set; }
        public int status { get; set;  }
        public string reponse { get; set; }
        public string AppealedReason
        {
            get
            {
                return AppealedReport.description;
            }
        }
        public string AppealedImage
        {
            get
            {
                return AppealedReport.image;
            }
        }
        public void Insert()
        {
            ID = DBAppeal.insert(AppealedReport.ID, Reason, status, reponse);
        }

        public Appeal(int iD, Report report, string reason, int status, string response)
        {
            ID = iD;
            AppealedReport = report;
            Reason = reason;
            this.status = status;
            this.reponse = response;
        }
        private Appeal(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            AppealedReport = new Report((int)dataRow["report"]);
            Reason = (string)dataRow["reason"];
            status = (int)dataRow["status"];
            reponse = (string)dataRow["response"];
        }
        public static List<Appeal> GetPending()
        {
            return (from DataRow row in DBAppeal.AppealsByStatus(Status.pending).Rows select new Appeal(row)).ToList();
        }
        public void Update(int status)
        {
            DBAppeal.UpdateStatus(status, ID);
        }
    }
}
