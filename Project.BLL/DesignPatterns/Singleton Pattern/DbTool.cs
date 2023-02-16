using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.Singleton_Pattern
{
    using Project.DAL.Context;
    public class DbTool
    {
        DbTool() { }
         private static MyContext _dbInstance;

        public static MyContext DbInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance= new MyContext();
                }
                return _dbInstance;
            }
        }
    }
}
