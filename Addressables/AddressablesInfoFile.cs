namespace mcf.addressables
{
    [System.Serializable]
    public class AddressablesInfoFile
    {
        public string modName;
        public string modIdentifier;
        public uint modID;
        public int backingType;
        public bool disableRequiresRestart;
        public bool enableRequiresRestart;
    }
}