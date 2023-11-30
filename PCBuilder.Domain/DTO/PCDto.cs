using PCBuilder.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace PCBuilder.DTO
{
    public class PCDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        /*public int CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string CreatorLink { get; set; }*/
        public int Cost { get; set; }
        public Component CPU { get; set; }
        public Component GPU { get; set; }
        public Component MotherBoard { get; set; }
        public Component DRAM { get; set; }
        public Component PowerSupply { get; set; }
        public Component Case { get; set; }
        public Component PCColling { get; set; }
        public Component Storages { get; set; }
        public Component Fans { get; set; }
    }
}
