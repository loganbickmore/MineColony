using DanielEverland.ScriptableObjectArchitecture.Variables;
using UnityEngine;

namespace DanielEverland.ScriptableObjectArchitecture.References
{
    [System.Serializable]
    public sealed class QuaternionReference : BaseReference<Quaternion, QuaternionVariable>
    {
        public QuaternionReference() : base() { }
        public QuaternionReference(Quaternion value) : base(value) { }
    }
}