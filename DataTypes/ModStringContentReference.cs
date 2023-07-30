using System;

namespace mcf
{
    [System.Serializable]
    public struct ModStringContentReference : IEquatable<ModStringContentReference>
    {
        public string modGUID;
        public int contentType;
        public string contentGUID;

        public ModStringContentReference(string modGUID, int contentType, string contentGuid)
        {
            this.modGUID = modGUID;
            this.contentType = contentType;
            this.contentGUID = contentGuid;
        }

        public ModStringContentReference(ModStringContentSetReference setReference, int contentType)
        {
            this.modGUID = setReference.modGUID;
            this.contentType = contentType;
            this.contentGUID = setReference.contentGUID;
        }
        
        public bool IsValid()
        {
            if (contentType == 0) return false;
            return true;
        }

        public override string ToString()
        {
            return $"{modGUID.ToString()}:{contentType.ToString()}:{contentGUID.ToString()}";
        }

        public bool Equals(ModStringContentReference other)
        {
            return contentType == other.contentType && modGUID.Equals(other.modGUID) && contentGUID.Equals(other.contentGUID);
        }

        public override bool Equals(object obj)
        {
            return obj is ModStringContentReference other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(modGUID, contentType, contentGUID);
        }
        
        public static bool operator ==(ModStringContentReference x, ModStringContentReference y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(ModStringContentReference x, ModStringContentReference y)
        {
            return !(x == y);
        }
    }
}