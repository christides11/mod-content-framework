using UnityEngine;

namespace mcf
{
    [CreateAssetMenu(fileName = "SharedModIDReference", menuName = "mcf/SharedModIDReference")]
    public class SharedModIDContentReference : ScriptableObject
    {
        public ModIDContentReference reference;
    }
}