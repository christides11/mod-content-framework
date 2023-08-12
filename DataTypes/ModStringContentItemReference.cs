using System;

namespace mcf
{
    [System.Serializable]
    public struct ModStringContentItemReference : IEquatable<ModStringContentSetItemReference>
    {
        public ModStringContentReference contentReference;
        public string ItemReference;

        public ModStringContentItemReference(string str)
        {
            var strs = str.Split(':');
            contentReference = new ModStringContentReference(strs[0], int.Parse(strs[1]), strs[2]);
            ItemReference = strs[3];
        }

        public override string ToString()
        {
            return $"{contentReference.ToString()}:{ItemReference}";
        }

        public bool Equals(ModStringContentSetItemReference other)
        {
            return contentReference.modGUID == other.contentReference.modGUID
                && contentReference.contentGUID == other.contentReference.contentGUID
                && ItemReference == other.ItemReference;
        }
    }
}