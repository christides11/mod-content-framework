using System;

namespace mcf
{
    [System.Serializable]
    public class ModInfo
    {
        public int backingType; // The type of mod this is. UMod, Addressables, etc.
        public Uri path; // The path to the mod folder, if applicable.
        public string modName;
        public string modNamespace;
        public uint modIdentifier;
        public bool commandLine;
        public bool disableRequiresRestart;
        public bool enableRequiresRestart;
    }
}