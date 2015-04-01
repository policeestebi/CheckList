using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseDAL;
using TriQuint.CheckList.DAL.Contexts;
using TriQuint.CheckList.DAL.Interfaces;
using TriQuint.CheckList.Entities;

namespace TriQuint.CheckList.DAL.Contexts
{
    public class CheckListContext : BaseCheckListContext, ICheckListContext //BaseContext<CheckListContext>
    {

        #region Constructor

        public CheckListContext():
            base()
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

        public IDbSet<CheckListTemplate> CheckListTemplates { get; set; }
        public IDbSet<CheckListItemTemplate> CheckListItemTemplates { get; set; }
        public IDbSet<TemplateSection> TemplateSections { get; set; }

        #endregion

        #region Attributes

        #endregion

        
    }
}
