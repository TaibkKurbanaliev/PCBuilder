using PCBuilder.DAL.Interfaces;
using PCBuilder.Domain.Entities;
using PCBuilder.DTO;
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

        public async Task Create(PCDto pc)
        {
            var newPC = new PC()
            {
                Name = pc.Name,
                Description = pc.Description,
                Cost = pc.Cost,
                CPU = pc.CPU,
                GPU = pc.GPU,
                MotherBoard = pc.MotherBoard,
                DRAM = pc.DRAM,
                PowerSupply = pc.PowerSupply,
                Case = pc.Case,
                PCColling = pc.PCColling,
                Fans = pc.Fans
            };

            await _repository.Create(newPC);
        }

        public async Task<PC> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<PC>> GetAll()
        {
            return await _repository.GetAll();
        }

        public Task Update(int id, string message)
        {
            throw new NotImplementedException();
        }


    }
}
