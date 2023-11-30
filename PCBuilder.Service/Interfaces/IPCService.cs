using PCBuilder.Domain.Entities;
using PCBuilder.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Service.Interfaces
{
    public interface IPCService
    {
        Task<PC> Get(int id);
        Task<IEnumerable<PC>> GetAll();
        Task Create(PCDto pc);
        Task Delete(int id);
        Task Update(int id, string message);
    }
}
