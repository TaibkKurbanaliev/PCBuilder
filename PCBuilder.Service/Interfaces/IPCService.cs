using PCBuilder.Domain.Entities;
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
        Task<List<PC>> GetAll();
        Task Create(PC pc);
        Task Delete(int id);
        Task Update(int id, string message);
    }
}
