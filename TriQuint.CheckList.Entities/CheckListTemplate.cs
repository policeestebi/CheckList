using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriQuint.CheckList.Entities
{
    public class CheckListTemplate: BaseEntity
    {
        #region Constructor

        #endregion

        #region Methods

        #endregion

        #region Properties

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<TemplateSection> TemplateSections { get; set; }

        #endregion

        #region Attributes

        #endregion

    }
}
