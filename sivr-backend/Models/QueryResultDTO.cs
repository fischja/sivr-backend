using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Models
{
    public class QueryResultDTO : IEquatable<QueryResultDTO>
    {
        public short V3CId { get; set; }
        public short KeyframeNumber { get; set; }

        public bool Equals([AllowNull] QueryResultDTO other)
        {
            if (other == null) 
                return false;

            return V3CId == other.V3CId && KeyframeNumber == other.KeyframeNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as QueryResultDTO);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(V3CId, KeyframeNumber);
        }
    }
}
