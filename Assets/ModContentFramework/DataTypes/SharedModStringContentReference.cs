using UnityEngine;

namespace mcf
{
    [CreateAssetMenu(fileName = "SharedModStringReference", menuName = "mcf/SharedModStringReference")]
    public class SharedModStringContentReference : ScriptableObject
    {
        public ModStringContentReference reference;
    }
}