using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Customer_source
{
	public class DataAccess
{

		public static int Sqlcode = 0;
		static SqlTransaction SQLtransaction;
		static SqlConnection connection;
		static SqlCommand command;

		static SqlDataReader reader;

		static string GetConnectionString()
		{
			return "Connection String";
		}

		static void InitializeConnection()
		{
			string connectionString = GetConnectionString();
			connection = new SqlConnection(connectionString);
			connection.Open();
			SQLtransaction = connection.BeginTransaction();
		}

		public static void Execute(string cmdText)
		{
			if (connection == null)
			{
				InitializeConnection();
			}

			Sqlcode = 0;
			command = new SqlCommand(cmdText, connection);

			if (reader != null)
			{
				reader.Close();
			}

			command.Transaction = SQLtransaction;

			try
			{
				reader = command.ExecuteReader();

				if (!reader.HasRows)
				{
					Sqlcode = -100;
				}
			}
			catch (SqlException Ex)
			{
				Sqlcode = -999;
			}
		}

		public static bool Read()
		{
			return reader.Read();
		}

        public static string ReadIntoString(int index)
        {
            string param = null;
            Type valueType = reader.GetValue(index).GetType();

            if (valueType.Name == "String")
            {
                param = reader.GetString(index);
            }
            return param;
        }

        public static int ReadIntoInt(int index)
        {
            int param = -1;
            Type valueType = reader.GetValue(index).GetType();

            if (valueType.Name == "Int32")
            {
                param = reader.GetInt32(index);
            }
            return param;
        }


    public static SqlDataReader Reader
		{
			get
			{
				return reader;
			}
		}

        internal static decimal ReadIntoDecimal(int v)
        {
            throw new NotImplementedException();
        }

        internal static long ReadIntoLong(int v)
        {
            throw new NotImplementedException();
        }
    }
}