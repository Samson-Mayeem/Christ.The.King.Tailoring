using Mark.Up.Fashion.Models.Domain;
using Mark.Up.Fashion.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Services
{
    public class PurchasesService
    {
        private readonly IPurchasesRepository _purchasesRepository;

        public PurchasesService(IPurchasesRepository purchasesRepository)
        {
            _purchasesRepository = purchasesRepository;
        }

        public async Task<IEnumerable<Purchases>> GetAllPurchases()
        {
            return await _purchasesRepository.GetAllAsync();
        }

        public async Task<Purchases> GetPurchaseById(long id)
        {
            return await _purchasesRepository.GetByIdAsync(id);
        }

        public async Task AddPurchase(Purchases purchases)
        {
            await _purchasesRepository.AddAsync(purchases);
        }

        public async Task UpdatePurchase(Purchases purchases)
        {
            await _purchasesRepository.UpdateAsync(purchases);
        }

        public async Task DeletePurchase(Purchases purchases)
        {
            await _purchasesRepository.DeleteAsync(purchases);
        }
    }
}
