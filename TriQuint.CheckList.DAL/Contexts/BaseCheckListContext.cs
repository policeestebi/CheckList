using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseDAL;

namespace TriQuint.CheckList.DAL.Contexts
{
    public class BaseCheckListContext : BaseContext<BaseCheckListContext>
    {
        #region Constructor

        public BaseCheckListContext()
            : base("CheckListContext")
        {

        }

        #endregion
    }
}
