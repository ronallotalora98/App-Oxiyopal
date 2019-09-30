using Oxiyopal.DataAccess.Base;
using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.DataAccess.Repository
{
    public interface IRepository<T, TId> : IRepositoryWithTypedId<T, TId> where T : IEntityWithTypedId<TId>
    {
    }
}
