using System;
using System.Diagnostics;

namespace DatabaseConnection
{
    public class SqlConnection: DbConnection
    {
        public SqlConnection(string str)
            : base(str)
        {    
        }
        public override void Open()
        {
            Debug.WriteLine("SQL Connection opened");
        }

        public override void Close()
        {
            Debug.WriteLine("SQL Connection closed");
        }
    }
}