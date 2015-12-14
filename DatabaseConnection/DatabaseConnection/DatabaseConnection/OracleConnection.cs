using System.Diagnostics;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string str)
            : base(str)
        {
        }
        public override void Open()
        {
            Debug.WriteLine("ORACLE Connection opened");
        }

        public override void Close()
        {
            Debug.WriteLine("ORACLE Connection closed");
        }
    }
}