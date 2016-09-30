using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVn.Data.Infrastructure
{
    //Thuc hien hanh dong SubmitChange cho nhieu doi tuong
    public interface IUnitOfWork
    {
        void Commit();
    }
}
