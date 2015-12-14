using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {

        private string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string str)
        {
            if (string.IsNullOrEmpty(str))
                    throw new ArgumentException("ConnectionString cannot be null or empty!");

            ConnectionString = str;

        }

        public abstract void Open();
        public abstract void Close();

    }
}