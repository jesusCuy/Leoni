using System;

namespace Leoni.Core.Domain.Common
{
    public class BaseEntity<TPrimaryKeyType> : AuditedEntity
    {
        public TPrimaryKeyType Id { get; set; }
    }
}
