using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriQuint.CheckList.Entities
{
    public class TemplateSection:BaseEntity
    {
        #region Constructor

        #endregion

        #region Methods

        #endregion

        #region Properties

        public string Name { get; set; }

        public string Description { get; set; }

        public string TemplateSectonID { get; set; }

        public virtual TemplateSection TemplateSectionParent { get; set; }

        public virtual ICollection<CheckListItemTemplate> CheckListItems { get; set; }

        #endregion

        #region Attributes

        #endregion
    }
}
