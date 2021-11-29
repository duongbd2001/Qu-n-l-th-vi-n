using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace Bussiness
{
    public class UserBusiness
    {
        private Connector.Connector connect = null;
        public UserBusiness()
        {
            connect = new Connector.Connector();
        }

        public List<User> getUser(string username, string password)
        {
            SqlDataAdapter adap = null;
            List<User> ds = new List<User>();
            try
            {
                string sql = "select id, username, [password] from [USER] where [username]=@username and [password] =@password";
                Dictionary<String, object> param = new Dictionary<string, object>();
                param.Add("username", username);
                param.Add("password", password);

                adap = connect.getData(sql, param);

                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    User us = new User();
                    us.id = int.Parse(dt.Rows[i][0].ToString());
                    us.userName = dt.Rows[i][1].ToString();
                    us.password = dt.Rows[i][2].ToString();
                    ds.Add(us);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
