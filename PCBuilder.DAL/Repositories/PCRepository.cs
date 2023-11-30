using PCBuilder.DAL.Interfaces;
using PCBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.DAL.Repositories
{
    public class PCRepository : IPCRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PCRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Create(PC pc)
        {
            await _dbContext.AddAsync(pc);

            return await Save();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(PC entity)
        {
            throw new NotImplementedException();
        }

        public Task<PC> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PC>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Save()
        {
            var result = await _dbContext.SaveChangesAsync();

            return result > 0;
        }
    }
}
