using System;

namespace mcf
{
    [System.Serializable]
    public struct ModIDContentReference : IEquatable<ModIDContentReference>
    {
        public uint modID;
        public int contentType;
        public int contentIdx;

        public ModIDContentReference(uint modID, int contentType, int contentIdx)
        {
            this.modID = modID;
            this.contentType = contentType;
            this.contentIdx = contentIdx;
        }
        
        public bool IsValid()
        {
            if (contentType == 0) return false;
            return true;
        }

        public override string ToString()
        {
            return $"{modID}:{contentType}:{contentIdx}";
        }

        public bool Equals(ModIDContentReference other)
        {
            return contentType == other.contentType && modID.Equals(other.modID) && contentIdx.Equals(other.contentIdx);
        }

        public override bool Equals(object obj)
        {
            return obj is ModIDContentReference other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(modID, contentType, contentIdx);
        }
        
        public static bool operator ==(ModIDContentReference x, ModIDContentReference y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(ModIDContentReference x, ModIDContentReference y)
        {
            return !(x == y);
        }
    }
}