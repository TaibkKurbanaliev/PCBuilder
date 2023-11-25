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
        public Task<bool> Create(PC entity)
        {
            throw new NotImplementedException();
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

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
