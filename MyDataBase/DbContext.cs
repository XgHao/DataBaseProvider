using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase
{
    /// <summary>
    /// 数据库连接-配置信息
    /// </summary>
    public class DbContext
    {
        /// <summary>
        /// 连接信息
        /// </summary>
        private static ConnectionConfig ConConfig = new ConnectionConfig
        {
            ConnectionString = ConfigurationManager.AppSettings["DbConfig"].ToString(),
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        };

        ///连接实例
        public SqlSugarClient Db { get; } = new SqlSugarClient(ConConfig);
    }
}
