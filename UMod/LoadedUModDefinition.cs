using UMod;

namespace mcf.umod
{
    public class LoadedUModModDefinition : LoadedModDefinition
    {
        public ModHost host;

        public override void Unload()
        {
            host.UnloadMod();
        }
    }
}