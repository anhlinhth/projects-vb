using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WorkTime.SQL_CONNECT
{
    class SQL_CONN
    {
        private SqlConnection conn;
        public static String strConn = System.Configuration.ConfigurationManager.ConnectionStrings["DATABASE_SQL"].ConnectionString;
        private SqlDataAdapter myAdapter;

        public SQL_CONN()
        {
            conn = new SqlConnection(strConn);
            myAdapter = new SqlDataAdapter(); 
        }

        public SqlConnection DBConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }


        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            try
            {
                myCommand.Connection = DBConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(dataTable);
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public DataTable executeSelectQuery(String _query)
        {
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = DBConnection();
                cmd.CommandText = _query;
                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(tb);
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == -2)
                    MessageBox.Show("Thời gian kết nối dữ liệu quá lâu. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất hiện lỗi:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tb;
        }

        /// <method>
        /// Insert Query
        /// </method>
        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = DBConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public bool executeInsertQuery(String _query)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = DBConnection();
                myCommand.CommandText = _query;
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        /// <method>
        /// Update Query
        /// </method>
        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = DBConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public bool executeUpdateQuery(String _query)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = DBConnection();
                myCommand.CommandText = _query;
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
