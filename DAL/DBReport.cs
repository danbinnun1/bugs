using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBReport
    {
        public static DataTable AllReports()
        {
            return DalHelper.AllFromTable("reports");
        }
        public static DataTable ReportsByStatus(int status)
        {
            return DalHelper.Select("SELECT * FROM reports WHERE [status] = " + status + ";");
        }
        public static int AddReport(string description, int reporter, string time, string response, string image, int status)
        {
              return DalHelper.Insert(
                "INSERT INTO reports " +
                "([description], reporter, reportdate, moderatorResponse, [image], [status])" +
                $" VALUES ('{description}', {reporter}, '{time}', '{response}', '{image}', {status});");
        }
        public static void Update(string response, int status, int id)
        {
            DalHelper.Update("UPDATE reports SET moderatorResponse = '" + response + "', [status] = " + status + " WHERE [ID]=" + id + ";");
        }
        public static void UpdateImage(int id, string image)
        {
            DalHelper.Update("UPDATE reports SET [image] = '" + image + "' WHERE ID = " + id + ";");
        }
    }
}
