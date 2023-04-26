using System;

namespace mcf
{
    [System.Serializable]
    public struct ModIDContentSetReference : IEquatable<ModIDContentSetReference>
    {
        public uint modID;
        public int contentIdx;

        public ModIDContentSetReference(uint modID, int contentIdx)
        {
            this.modID = modID;
            this.contentIdx = contentIdx;
        }

        public bool IsValid()
        {
            if (modID == 0) return false;
            return true;
        }

        public override string ToString()
        {
            return $"{modID}:{contentIdx}";
        }

        public bool Equals(ModIDContentSetReference other)
        {
            return modID.Equals(other.modID) && contentIdx.Equals(other.contentIdx);
        }

        public override bool Equals(object obj)
        {
            return obj is ModIDContentSetReference other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(modID, contentIdx);
        }

        public static bool operator ==(ModIDContentSetReference x, ModIDContentSetReference y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(ModIDContentSetReference x, ModIDContentSetReference y)
        {
            return !(x == y);
        }
    }
}