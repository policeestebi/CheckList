using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TriQuint.CheckList.Entities;
using TriQuint.CheckList.DAL.Context;

namespace TriQuint.CheckList.DAL
{
    public class CheckListInitializer:DropCreateDatabaseIfModelChanges<CheckListContext>
    {
        #region Constructor

        #endregion

        #region Methods

        protected override void Seed(CheckListContext context)
        {
            base.Seed(context);
        }

        #endregion

        #region Properties

        #endregion

        #region Attributes

        #endregion
    }
}
