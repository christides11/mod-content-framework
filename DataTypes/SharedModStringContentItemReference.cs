using UnityEngine;

namespace mcf
{
    [CreateAssetMenu(fileName = "SharedModStringContentItemReference", menuName = "mcf/SharedModStringContentItemReference")]
    public class SharedModStringContentItemReference : ScriptableObject
    {
        public ModStringContentItemReference reference;
    }
}