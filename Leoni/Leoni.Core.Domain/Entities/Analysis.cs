using Leoni.Core.Domain.Common;
using System;

namespace Leoni.Core.Domain.Entities
{
    public class Analysis : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CreatedByUserId { get; set; }
    }
}
