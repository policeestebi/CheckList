using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseInterfaces;
using TriQuint.CheckList.DAL.Interfaces;
using TriQuint.CheckList.Entities;
using TriQuint.CheckList.Interfaces.Repositories;

namespace TriQuint.CheckList.Repositories
{
    public sealed class CheckListTemplateRepository:GenericRepository<CheckListTemplate>, ICheckListTemplateRepository
    {
        #region Constructor

        public CheckListTemplateRepository(IUnitOfWork uow):
            base(uow)
        {
           
        }

        public CheckListTemplateRepository(IContext context):
            base(context)
        {
            
        }

        #endregion

        #region Methods

        #endregion

        #region ICheckListTemplateRepositoryMembers

        #endregion

        #region IDisposableMembers

        #endregion

        #region Properties

        #endregion

        #region Attributes

        #endregion

    }
}
