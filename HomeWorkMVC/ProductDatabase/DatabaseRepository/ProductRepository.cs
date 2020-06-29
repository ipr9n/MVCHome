using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductDatabase.Entity;
using ProductDatabase.Interfaces;

namespace ProductDatabase.DatabaseRepository
{
   public  class ProductRepository : IReposInterface<Product>
    {
        DbContext _context;
            DbSet<Product> _dbSet;

            public ProductRepository(DbContext context)
            {
                _context = context;
                _dbSet = context.Set<Product>();
            }

            public IEnumerable<Product> Get()
            {
                return _dbSet.ToList();
            }

            public Product GetById(int id)
            {
                return _dbSet.Find(id);
            }

            public void Add(Product item)
            {
                _dbSet.Add(item);
                _context.SaveChanges();
            }

            public void Update(Product item)
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }

            public void Remove(Product item)
            {
                _dbSet.Remove(item);
                _context.SaveChanges();
            }
    }
}
