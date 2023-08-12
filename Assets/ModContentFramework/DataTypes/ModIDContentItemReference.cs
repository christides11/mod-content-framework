using UMod.BuildEngine;

namespace mcf
{
    [System.Serializable]
    public struct ModIDContentItemReference
    {
        public ModIDContentReference contentReference;
        public int ItemReference;

        public ModIDContentItemReference(string str)
        {
            var strs = str.Split(':');
            contentReference = new ModIDContentReference(uint.Parse(strs[0]), int.Parse(strs[1]), int.Parse(strs[2]));
            ItemReference = int.Parse(strs[3]);
        }

        public override string ToString()
        {
            return $"{contentReference.ToString()}:{ItemReference}";
        }
    }
}