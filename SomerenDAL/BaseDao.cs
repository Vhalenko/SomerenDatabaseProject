using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Collections;

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

        /*Get All*/

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

        internal protected abstract T Convert(DataRow reader);

        private protected abstract string GetAllQuery();

        /*CRUD*/

        public void AddItem(T item)
        {
            ExecuteEditQuery(QueryToAddItem(), GetParametersToAddItem(item));
        }

        protected abstract string QueryToAddItem();

        protected abstract SqlParameter[] GetParametersToAddItem(T item);

        public void DeleteItem(T item)
        {
            ExecuteEditQuery(QueryToDeleteItem(), GetParametersToDeleteItem(item));
        }

        protected abstract string QueryToDeleteItem();

        protected abstract SqlParameter[] GetParametersToDeleteItem(T item);

        public void UpdateItem(T item)
        {
            ExecuteEditQuery(QueryToUpdateItem(), GetParametersToUpdateItem(item));
        }

        protected abstract string QueryToUpdateItem();

        protected abstract SqlParameter[] GetParametersToUpdateItem(T item);

        /*Getting data*/

        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            try
            {
                dbConnection.Open();
                using SqlCommand command = new(query, dbConnection);
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception("Check your internet connection!");
            }
            finally
            {
                dbConnection.Close();
            }
        }

        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new();

            try
            {
                using SqlCommand command = new(query, dbConnection);
                command.Parameters.AddRange(sqlParameters);

                using SqlDataAdapter adapter = new(command);
                adapter.Fill(dataTable);
            }
            catch (SqlException)
            {
                throw new Exception("Check your internet connection!");
            }
            return dataTable;
        }
    }
}