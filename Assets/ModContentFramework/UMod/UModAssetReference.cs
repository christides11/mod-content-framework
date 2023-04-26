using UnityEngine;

namespace mcf.umod
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "UModAssetReference", menuName = "mcf/UMod/Asset Reference")]
    public class UModAssetReference : ScriptableObject
    {
        public string path;
    }
}