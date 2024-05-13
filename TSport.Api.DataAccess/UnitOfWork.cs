using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.DataAccess.Interfaces;
using TSport.Api.DataAccess.Repositories;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly ConcurrentDictionary<Type, object> _repositories;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _repositories = [];
        }

        public IGenericRepository<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories.TryGetValue(typeof(T), out object? repository))
            {
                return (IGenericRepository<T>)repository;
            }

            var repositoryType = typeof(GenericRepository<>);
            var repositoryInstance = (IGenericRepository<T>)Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context)!;

            return (IGenericRepository<T>)_repositories.GetOrAdd(typeof(T), repositoryInstance);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
