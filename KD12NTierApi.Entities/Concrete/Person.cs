using KD12NTierApi.Core.Enums;
using KD12NTierApi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.Entities.Concrete
{
    public class Person : IPerson
    {
        public Status Status { get; set; }
        public string CreatedBy { get; set; } = "Şahin Uzun";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public int Id { get; set; }
    }
}
