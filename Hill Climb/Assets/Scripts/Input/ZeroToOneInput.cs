using UnityEngine;

namespace MyInput
{
    public abstract class ZeroToOneInput : MonoBehaviour
    {
        private INormalizedProperty _normalizedProperty;

        public void Init( INormalizedProperty normalizedProperty)
        {
            _normalizedProperty = normalizedProperty;
        }

        protected void SetZeroToOneValue(float speed)
        {
            _normalizedProperty.ZeroToOne = speed;
        }
    }
}