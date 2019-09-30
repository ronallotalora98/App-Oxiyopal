using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models.Base
{
    public abstract class EntityBase<Tid> : EntityBaseWithTypedId<Tid>
    {
        /// <summary>
        /// Date of creation of the record
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Date of update of the record
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Default constructor, create a new object with CreatedOn and UpdatedOn dates using DateTime.Now
        /// </summary>
        public EntityBase()
        {
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
    }
}
