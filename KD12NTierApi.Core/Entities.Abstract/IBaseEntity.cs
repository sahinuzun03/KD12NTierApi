using KD12NTierApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12NTierApi.Core.Entities.Abstract
{
    public interface IBaseEntity : IBase
    {
        int Id { get; set; }
        Status Status { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string? ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        string? DeletedBy { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
