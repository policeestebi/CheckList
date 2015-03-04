using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseDAL;
using TriQuint.CheckList.DAL.Interfaces;
using TriQuint.CheckList.Entities;

namespace TriQuint.CheckList.DAL.Context
{
    public class CheckListContext: BaseContext<CheckListContext>, ICheckListContext
    {

        #region Constructor

        public CheckListContext()
            : base("CheckListContext")
        {

        }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void SetAdd(object entity)
        {
            Entry(entity).State = EntityState.Added;
        }

        #endregion

        #region Properties

        public DbSet<CheckListTemplate> CheckListTemplates { get; set; }

        #endregion

        #region Attributes

        #endregion

        
    }
}
