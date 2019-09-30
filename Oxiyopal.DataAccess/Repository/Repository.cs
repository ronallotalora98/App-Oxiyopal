using Oxiyopal.DataAccess.Base;
using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.DataAccess.Repository
{
    public class Repository<T, TId> : RepositoryWithTypedId<T, TId>, IRepository<T, TId>
     where T : class, IEntityWithTypedId<TId>
    {
        public Repository(OxiyopalDbContext context) : base(context)
        {

        }
    }
}
