using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.Models.Base
{
    public interface IEntityWithTypedId<TId>
    {
        /// <summary>
        /// property that identifies the class that will implement this interface 
        /// </summary>
        TId Id { get; }
    }
}
