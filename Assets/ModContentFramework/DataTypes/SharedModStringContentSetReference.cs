using UnityEngine;

namespace mcf
{
    [CreateAssetMenu(fileName = "SharedModStringContentSetReference", menuName = "mcf/SharedModStringContentSetReference")]
    public class SharedModStringContentSetReference : ScriptableObject
    {
        public ModStringContentSetReference reference;
    }
}