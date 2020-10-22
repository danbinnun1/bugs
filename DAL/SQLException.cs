using System;

namespace DAL
{
    internal class SqlException : Exception
    {
        public SqlException() : base("SQL Error")
        {
        }
    }
}