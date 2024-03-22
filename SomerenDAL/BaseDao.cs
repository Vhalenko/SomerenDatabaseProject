using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;

namespace SomerenDAL
{
    public abstract class BaseDao<T>
    {
        protected SqlDataAdapter adapter;
        protected SqlConnection dbConnection;

        public BaseDao()
        {
            dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        public List<T> GetAll()
        {
            SqlParameter[] sqlParameters = Array.Empty<SqlParameter>();
            return ReadTables(ExecuteSelectQuery(GetAllQuery(), sqlParameters));
        }

        protected List<T> ReadTables(DataTable dataTable)
        {
            List<T> items = new();

            foreach (DataRow reader in dataTable.Rows)
            {
                T item = Convert(reader);
                items.Add(item);
            }

            return items;
        }

        private protected abstract T Convert(DataRow reader);

        private protected abstract string GetAllQuery();

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (dbConnection.State == ConnectionState.Closed || dbConnection.State == ConnectionState.Broken)
                {
                    dbConnection.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("You are not connected to the database!");
            }
            return dbConnection;
        }

        protected void CloseConnection()
        {
            dbConnection.Close();
        }

        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, dbConnection, sqlTransaction);

            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
    }
}