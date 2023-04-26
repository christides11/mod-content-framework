using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.AddressableAssets;

namespace mcf.addressables
{
    public class LoadedAddressablesModDefinition : LoadedModDefinition
    {
        public AsyncOperationHandle<IResourceLocator> resourceLocatorHandle;
        public ResourceLocationMap resourceLocationMap;

        public override void Unload()
        {
            resourceLocationMap = null;
            Addressables.Release(resourceLocatorHandle);
        }
    }
}