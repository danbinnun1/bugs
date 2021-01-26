using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBAppeal
    {
        public static int insert(int reportID, string reason, int status, string response)
        {
            return DalHelper.Insert("INSERT INTO appeals ([report], [reason], [status], [response]) VALUES (" + reportID + ", '" + reason + "', " + status+", '"+response+"');");
        }
        public static DataTable AllAppeals()
        {
            return DalHelper.AllFromTable("appeals");
        }
        public static DataTable AppealsByStatus(int status)
        {
            return DalHelper.Select("SELECT * FROM appeals WHERE [status] = " + status + ";");
        }
        public static void UpdateStatus(int status, int id)
        {
            DalHelper.Update("UPDATE appeals SET [status] = " + status + " WHERE [ID]=" + id + ";");
        }
    }
}
