using UnityEngine.AddressableAssets;

namespace mcf.addressables
{
    [System.Serializable]
    public class IdentifierAssetReferenceRelation<T> where T : UnityEngine.Object
    {
        public string identifier;
        public AssetReferenceT<T> asset;
    }
}