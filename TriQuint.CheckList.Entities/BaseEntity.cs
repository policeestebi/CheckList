using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriQuint.BaseInterfaces;

namespace TriQuint.CheckList.Entities
{
    public class BaseEntity : IObjectWithState
    {
        #region Constructor

        #endregion

        #region Methods

        #endregion

        #region Properties

        public int Id { get; set; }

        public string InsertedUser { get; set; }

        public DateTime InsertedDate { get; set; }

        public string LastUpdateUser { get; set; }

        public string LastUpdateDate { get; set; }

        public bool IsDeleted { get; set; }

        [NotMapped]
        public State State
        {
            get;
            set;
        }


        #endregion

        #region Attributes

        #endregion

        
    }
}
