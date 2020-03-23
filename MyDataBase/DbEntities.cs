using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase
{
    public class DbEntities<T> : DbContext where T : class, new()
    {
        public SimpleClient<T> GetSimpleClient() => new SimpleClient<T>(Db);
    }
}
