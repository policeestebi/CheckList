using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseInterfaces;

namespace TriQuint.BaseDAL.Extensions
{
    public static class ContextHelper
    {

        #region Constructor

        #endregion

        #region Methods

        //Only use with short lived contexts 
        public static void ApplyStateChanges(this DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries<IObjectWithState>())
            {
                var stateInfo = entry.Entity;
                entry.State = StateHelpers.ConvertState(stateInfo.State);
            }
        }

        #endregion

        #region Properties

        #endregion

        #region Attributes

        #endregion

        

    }
}
