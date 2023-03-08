using Mark.Up.Fashion.Data;
using Mark.Up.Fashion.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mark.Up.Fashion.Data.MarkupCoreEF;

namespace Mark.Up.Fashion.Repository
{
    public class PurchasesRepo
    {
        private readonly DataContext _dbContext;

        public PurchasesRepo(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Purchases>> GetAllAsync()
        {
            return await _dbContext.Purchases.ToListAsync();
        }

        public async Task<Purchases> GetByIdAsync(long id)
        {
            return await _dbContext.Purchases.FindAsync(id);
        }

        public async Task AddAsync(Purchases purchases)
        {
            await _dbContext.Purchases.AddAsync(purchases);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Purchases purchases)
        {
            _dbContext.Entry(purchases).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Purchases purchases)
        {
            _dbContext.Purchases.Remove(purchases);
            await _dbContext.SaveChangesAsync();
        }
    }
}