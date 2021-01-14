using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DBReport
    {
        public static DataTable AllReports()
        {
            return DalHelper.AllFromTable("reports");
        }
        //public static void AddReport(string image, string description, string name, int reporter)
        //{
        //    return DalHelper.Insert(
        //        "INSERT INTO reports" +
        //        "(image, description, name, reporter)" +
        //        $"VALUES('{image}','{description}', '{name}', {reporter})");
        //}
    }
}
