using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriQuint.CheckList.Entities
{
    public class CheckListItemTemplate:BaseEntity
    {
        #region Constructor

        #endregion

        #region Methods

        #endregion

        #region Properties

        public string Name { get; set; }

        public string Description { get; set; }

        public  string TemplateSectionID { get; set; }

        public virtual TemplateSection TemplateSection { get; set; }

        #endregion

        #region Attributes

        #endregion
    }
}
