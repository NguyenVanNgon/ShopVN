using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVn.Data.Infrastructure
{
    //Tu dong khoi tao doi tuong DbContext
   public  interface IDbFactory:IDisposable
    {

       ShopVNDbContext Init();
    }
}
