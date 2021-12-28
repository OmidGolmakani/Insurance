using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Repository
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}
