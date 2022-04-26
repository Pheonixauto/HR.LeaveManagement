using HR.LeaveManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HrLeaveManagementDbContext _hrLeaveManagementDbContext;
        public GenericRepository(HrLeaveManagementDbContext hrLeaveManagementDbContext)
        {
            _hrLeaveManagementDbContext = hrLeaveManagementDbContext;
        }
        public async Task<T> Add(T entity)
        {
            await _hrLeaveManagementDbContext.AddAsync(entity);
            await _hrLeaveManagementDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _hrLeaveManagementDbContext.Set<T>().Remove(entity);
            await _hrLeaveManagementDbContext.SaveChangesAsync();
        }

        public async Task<bool> Exist(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }
        public async Task<T> Get(int id)
        {
           var entity = await _hrLeaveManagementDbContext.Set<T>().FindAsync(id);
            return entity!;
        }
        public async Task<IReadOnlyList<T>> GetAll()
        {
            var entities = await _hrLeaveManagementDbContext.Set<T>().ToListAsync();
            return entities;
        }

        public async Task Update(T entity)
        {
            _hrLeaveManagementDbContext.Entry(entity).State = EntityState.Modified;
            await _hrLeaveManagementDbContext.SaveChangesAsync();
        }
    }
}
