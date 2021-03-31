using System;
using System.Collections.Generic;
using System.Text;

namespace Leoni.Core.Domain.Common
{
    public class AuditedEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
