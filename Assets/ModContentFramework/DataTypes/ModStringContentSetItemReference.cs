namespace mcf
{
    [System.Serializable]
    public struct ModStringContentSetItemReference
    {
        public ModStringContentSetReference contentReference;
        public string ItemReference;

        public ModStringContentSetItemReference(string str)
        {
            var strs = str.Split(':');
            contentReference = new ModStringContentSetReference(strs[0], strs[1]);
            ItemReference = strs[2];
        }

        public override string ToString()
        {
            return $"{contentReference.ToString()}:{ItemReference}";
        }
    }
}