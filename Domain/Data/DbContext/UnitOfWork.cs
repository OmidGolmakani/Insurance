﻿using Domain.Interfaces.Fundamentals.Repository;
using System.Threading.Tasks;

namespace Domain.Data.DbContext
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbFactory _dbFactory;
        public UnitOfWork(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        /// <summary>
        /// Save changes data from entity to database
        /// </summary>
        /// <returns></returns>
        public Task<int> CommitAsync()
        {
            return _dbFactory.DbContext.SaveChangesAsync();
        }
    }
}
