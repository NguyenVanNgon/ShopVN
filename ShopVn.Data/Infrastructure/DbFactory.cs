using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVn.Data.Infrastructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        private ShopVNDbContext dbContext;


        public ShopVNDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopVNDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
