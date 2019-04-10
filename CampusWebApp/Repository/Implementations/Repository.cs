using CampusWebApp.Models;
using CampusWebApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CampusWebApp.Repository.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext _context { get; set; }

        public Repository(ApplicationDbContext context) => _context = context;


        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(int id)
        {
            var type = _context.Set<T>().FindAsync(id);
            _context.Remove(type);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
        }
    }
}
