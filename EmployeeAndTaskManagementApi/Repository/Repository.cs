using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAndTaskManagementApi.Models.DataContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAndTaskManagementApi.Repository
{
    public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAll() => await _dbSet.ToListAsync();

    public async Task<T> GetById(int id) => await _dbSet.FindAsync(id);

    public async Task Add(T entity) => await _dbSet.AddAsync(entity);

    public async Task Update(T entity)
    {
        _dbSet.Update(entity);
        await SaveAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await GetById(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await SaveAsync();
        }
    }

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}

}