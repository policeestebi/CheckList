using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriQuint.BaseDAL
{
    public class BaseContext<TContext> : 
            DbContext where TContext : DbContext
    {
        #region Constructor

        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext(string conn) 
            : base("name=" + conn)
        {}

        #endregion

        #region Methods

        #endregion

        #region Properties

        #endregion

        #region Attributes

        #endregion
    }
}
