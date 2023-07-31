using UnityEngine;

namespace mcf
{
    [CreateAssetMenu(fileName = "SharedModStringContentSetItemReference", menuName = "mcf/SharedModStringContentSetItemReference")]
    public class SharedModStringContentSetItemReference : ScriptableObject
    {
        public ModStringContentSetItemReference reference;
    }
}