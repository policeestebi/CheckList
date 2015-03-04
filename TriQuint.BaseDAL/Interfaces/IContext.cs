using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriQuint.BaseDAL.Interfaces
{
    public interface IContext: IDisposable
    {
        int SaveChanges();

        void SetModified(object entity);

        void SetAdd(object entity);
    }
}
