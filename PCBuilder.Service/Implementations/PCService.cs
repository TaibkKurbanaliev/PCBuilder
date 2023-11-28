using PCBuilder.DAL.Interfaces;
using PCBuilder.Domain.Entities;
using PCBuilder.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Service.Implementations
{
    public class PCService : IPCService
    {
        private readonly IPCRepository _repository;

        public PCService(IPCRepository repository)
        {
            _repository = repository;
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task Create(PC pc)
        {

        }

        public Task<PC> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PC>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, string message)
        {
            throw new NotImplementedException();
        }


    }
}
