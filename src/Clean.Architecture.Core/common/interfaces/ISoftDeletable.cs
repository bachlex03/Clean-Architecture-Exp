using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.interfaces
{
    public interface ISoftDeletable
    {
        public DateTime DeletedDate { get; set; }
        public string DeletedByUserId { get; set; }
    }
}