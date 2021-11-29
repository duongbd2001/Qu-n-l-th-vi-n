using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Connector
{
    public class Connector
    {
        String strconnect = @"Data Source=DESKTOP-OHVB6QL;Initial Catalog=btl_csdl;Integrated Security=True";
        private SqlCommand cmd = null;
        private SqlDataAdapter adap = null;
        private SqlConnection conn = null;
        public Connector()
        {
            conn = new SqlConnection(strconnect);
        }

        //Tạo kết nối tới DB
        public void OpenConnect()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Ngắt kết nối với DB
        public void CloseConnect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy dữ liệu
        /// </summary>
        /// <param name="procname">ten thu tuc</param>
        /// <returns>tra ve SqlDataAdapter</returns>
        public SqlDataAdapter getData(string sql, Dictionary<String, object> param)
        {
            try
            {
                this.OpenConnect();
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                adap = new SqlDataAdapter(cmd);
                if(param != null)
                {
                    foreach(KeyValuePair<string, object> entry in param)
                    {
                        adap.SelectCommand.Parameters.AddWithValue("@" + entry.Key, entry.Value);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return adap;
        }

        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        public void saveData(string sql, Dictionary<string, object> param)
        {
            try
            {
                this.OpenConnect();
                cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<string, object> item in param)
                {
                    cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// Xóa dữ liệu
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        public void deleteData(string sql, Dictionary<string, object> param)
        {
            try
            {
                this.OpenConnect();
                cmd = new SqlCommand(sql, conn);
                foreach (KeyValuePair<string, object> item in param)
                {
                    cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
