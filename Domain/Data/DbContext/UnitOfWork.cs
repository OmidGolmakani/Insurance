using Domain.Interfaces.Fundamentals.Repository;
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
        public Task OpenConnectionAsync()
        {
            if (_dbFactory.DbConnection.State != System.Data.ConnectionState.Open) return _dbFactory.DbConnection.OpenAsync();
            return _dbFactory.DbConnection.OpenAsync();
        }
        public Task CloseConnectionAsync()
        {
            if (_dbFactory.DbConnection.State != System.Data.ConnectionState.Open) return _dbFactory.DbConnection.CloseAsync();
            return _dbFactory.DbConnection.CloseAsync();
        }
    }
}
