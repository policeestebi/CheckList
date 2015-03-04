using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseEntities.Interfaces;

namespace TriQuint.BaseDAL
{
    public class StateHelpers
    {
        #region Constructor

        #endregion

        #region Methods

        public static EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Modified:
                    return EntityState.Modified;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

        #endregion

        #region Properties

        #endregion

        #region Attributes

        #endregion
    }
}
