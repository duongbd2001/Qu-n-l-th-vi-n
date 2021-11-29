using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class CommonUtil
    {
        public static void convertSQL(ref string sql, ref Dictionary<String, object> param, string nameFile, object value, string nameParam)
        {
            if(value != null && int.Parse(value.ToString()) >0)
            {
                sql += " AND " + nameFile + " = @" + nameParam;
                param.Add(nameParam, value);
            }
        }
        public static void convertLike(ref string sql, ref Dictionary<String, object> param, string nameFile, object value, string nameParam)
        {
            if (!"".Equals(value))
            {
                sql += " AND " + nameFile + " LIKE @" + nameParam;
                param.Add(nameParam, "%" + value + "%");
            }
        }
    }
}
