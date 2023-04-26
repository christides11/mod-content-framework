using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mcf.sample.simple
{
    [CreateAssetMenu(fileName = "EntityDefinition", menuName = "mcf/samples/simple/definions/entity")]
    public class EntityDefinition : IContentDefinition
    {
        public override async UniTask<bool> Load()
        {
            return true;
        }

        public override bool Unload()
        {
            return true;
        }
    }
}