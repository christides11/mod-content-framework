using System;

namespace mcf
{
    [System.Serializable]
    public class ModInfo
    {
        public int backingType;
        public Uri path;
        public string modName;
        public string modNamespace;
        public uint modIdentifier;
        public bool commandLine;
        public bool disableRequiresRestart;
        public bool enableRequiresRestart;
    }
}