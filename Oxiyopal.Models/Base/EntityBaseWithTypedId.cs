using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models.Base
{
    public abstract class EntityBaseWithTypedId<TId> : ValidatableObject, IEntityWithTypedId<TId>
    {
        /// <summary>
        /// property that identifies the class
        /// </summary>
        public virtual TId Id { get; set; }
    }
}
