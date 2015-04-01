using System;

namespace TriQuint.BaseInterfaces
{
    public interface IContext: IDisposable
    {
        int SaveChanges();

        void SetModified(object entity);

        void SetAdd(object entity);
    }
}
