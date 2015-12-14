using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("someString");
            //sql.Open();
            //sql.Close();

            var oracle = new OracleConnection("someString");
           // oracle.Open();
           // oracle.Close();

            var conn = new DbCommand(sql, "SELECT....");
            conn.Execute();

            var conn2 = new DbCommand(oracle, "SELECT....");
            conn2.Execute();
        }
    }
}
