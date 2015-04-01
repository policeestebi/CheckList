using System;

namespace TriQuint.BaseInterfaces
{
    public interface IUnitOfWork: IDisposable
    {
        int Save();
        IContext Context { get; }
    }
}
