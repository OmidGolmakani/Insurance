using System;
using System.Data.SqlClient;

namespace Domain.Data.DbContext
{
    public class DbFactory : IDisposable
    {
        private bool _disposed;
        private Func<AppDbContext> _instanceFunc;
        private Func<SqlConnection> _SqlinstanceFunc;
        private Microsoft.EntityFrameworkCore.DbContext _dbContext;
        private SqlConnection _dbConnection;
        public Microsoft.EntityFrameworkCore.DbContext DbContext => _dbContext ?? (_dbContext = _instanceFunc.Invoke());
        public SqlConnection DbConnection
        {
            get
            {
                if (_dbConnection == null) _dbConnection = _SqlinstanceFunc.Invoke();
                return _dbConnection;
            }
            set
            {
                _dbConnection = value;
            }
        }
        public DbFactory(Func<AppDbContext> dbContextFactory,
                         Func<SqlConnection> dbConnectionFactory)
        {
            _instanceFunc = dbContextFactory;
            _SqlinstanceFunc = dbConnectionFactory;
        }
        public void Dispose()
        {
            if (!_disposed && _dbContext != null)
            {
                _disposed = true;
                _dbContext.Dispose();
               

            }
            if (_dbConnection != null)
            {
                _dbConnection.Dispose();
            }
        }
    }
}
