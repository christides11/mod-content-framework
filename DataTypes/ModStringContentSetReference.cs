using System;

namespace mcf
{
    [System.Serializable]
    public struct ModStringContentSetReference : IEquatable<ModStringContentSetReference>
    {
        public string modGUID;
        public string contentGUID;

        public ModStringContentSetReference(string modGUID, string contentGuid)
        {
            this.modGUID = modGUID;
            this.contentGUID = contentGuid;
        }

        public ModStringContentSetReference(ModStringContentReference contentReference)
        {
            this.modGUID = contentReference.modGUID;
            this.contentGUID = contentReference.contentGUID;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(modGUID)) return false;
            return true;
        }

        public override string ToString()
        {
            return $"{modGUID.ToString()}:{contentGUID.ToString()}";
        }

        public bool Equals(ModStringContentSetReference other)
        {
            return modGUID.Equals(other.modGUID) && contentGUID.Equals(other.contentGUID);
        }

        public override bool Equals(object obj)
        {
            return obj is ModStringContentSetReference other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(modGUID, contentGUID);
        }

        public static bool operator ==(ModStringContentSetReference x, ModStringContentSetReference y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(ModStringContentSetReference x, ModStringContentSetReference y)
        {
            return !(x == y);
        }
    }
}