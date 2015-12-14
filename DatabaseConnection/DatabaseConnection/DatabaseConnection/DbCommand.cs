using System;
using System.Diagnostics;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _databaseC;
        private readonly string _instruction;

        public DbCommand(DbConnection dbc, string str)
        {
            if (dbc != null && str != null)
            { 
                _databaseC = dbc;
                _instruction = str;
            }
            else
                throw new InvalidOperationException();

            
        }

        public void Execute()
        {
            _databaseC.Open();
            Debug.WriteLine(_instruction);
            _databaseC.Close();
        }
        
    }
}