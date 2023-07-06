using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

namespace mcf
{
    public abstract class IContentDefinition : ScriptableObject
    {
        public virtual ModStringContentSetReference StringReference { get => stringReference; set { stringReference = value; } }
        public virtual int Identifier { get; set; }
        public virtual string Name { get; }
        public virtual string Description { get; }
        public virtual List<string> Tags => tags;

        protected ModStringContentSetReference stringReference;
        [SerializeField] protected List<string> tags;
        
        public abstract UniTask<bool> Load();
        public abstract bool Unload();
    }
}