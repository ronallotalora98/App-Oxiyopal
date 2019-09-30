﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Oxiyopal.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxiyopal.DataAccess.Base
{
    public class RepositoryWithTypedId<T, TId> : IRepositoryWithTypedId<T, TId> where T : class, IEntityWithTypedId<TId>
    {
        /// <summary>
        /// Database context
        /// </summary>
        protected DbContext Context { get; }

        /// <summary>
        /// Builds the object with the specified context
        /// </summary>
        /// <param name="context">Database context</param>
        public RepositoryWithTypedId(DbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        /// <summary>
        /// T Data in database
        /// </summary>
        protected DbSet<T> DbSet { get; }

        /// <summary>
        /// Adds an element to the Db
        /// </summary>
        /// <param name="entity">Object to add</param>
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        /// <summary>
        /// Detachs an element from  the Db
        /// </summary>
        /// <param name="entity">Element to detach</param>
        public void Detach(T entity)
        {
            Context.Entry(entity).State = EntityState.Detached;
        }

        /// <summary>
        /// Adds an element to the Db Asynchronously
        /// </summary>
        /// <param name="entity">Object to add</param>
        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        /// <summary>
        /// Begins the Db transaction
        /// </summary>
        /// <returns></returns>
        public IDbContextTransaction BeginTransaction()
        {
            return Context.Database.BeginTransaction();
        }

        /// <summary>
        /// Saves model changes
        /// </summary>
        /// <returns></returns>
        public int SaveChange()
        {
            return Context.SaveChanges();
        }

        /// <summary>
        /// Saves model changes Asynchronously
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangeAsync()
        {
            return await Context.SaveChangesAsync();
        }

        /// <summary>
        /// Allows the Query operations
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Query()
        {
            return DbSet;
        }


        /// <summary>
        /// Removes an element from the Db
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        /// <summary>
        /// Updates the given object
        /// </summary>
        /// <param name="entity">Object to update</param>
        /// <returns></returns>
        public void Update(T entity)
        {
            DbSet.Update(entity);
        }
    }
}
