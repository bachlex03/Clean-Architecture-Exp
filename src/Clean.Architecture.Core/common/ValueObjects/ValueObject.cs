using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.common.ValueObjects
{
    public class ValueObject : IEquatable<ValueObject>
    {
        public bool Equals(ValueObject other)
        {
            throw new NotImplementedException();
        }
    }
}