using System;

namespace mcf
{
    [System.Serializable]
    public struct ModStringContentItemReference : IEquatable<ModStringContentSetItemReference>
    {
        public ModStringContentReference contentReference;
        public string ItemReference;

        public bool Equals(ModStringContentSetItemReference other)
        {
            return contentReference.modGUID == other.contentReference.modGUID
                && contentReference.contentGUID == other.contentReference.contentGUID
                && ItemReference == other.ItemReference;
        }
    }
}