using Mark.Up.Fashion.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Repository
{
    public interface IPurchasesRepository
    {
        Task<IEnumerable<Purchases>> GetAllAsync();
        Task<Purchases> GetByIdAsync(long id);
        Task AddAsync(Purchases purchases);
        Task UpdateAsync(Purchases purchases);
        Task DeleteAsync(Purchases purchases);
    }
}
