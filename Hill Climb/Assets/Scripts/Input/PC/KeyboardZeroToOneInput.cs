using UnityEngine;

namespace MyInput.PC
{
    public class KeyboardZeroToOneInput : ZeroToOneInput
    {
        [SerializeField] private KeyCode button; 
        [SerializeField] private float acceleration = 0.1f;
        [SerializeField] private float deceleration = 0.1f;
        private float _value;
        public void Update()
        {
            if (Input.GetKey(button))
            {
                UpdateValue(acceleration * Time.deltaTime);
            }
            else
            {
                UpdateValue( -deceleration * Time.deltaTime);
            }
            SetZeroToOneValue(_value);
        }

        private void UpdateValue(float difference)
        {
            _value = Mathf.Clamp01(_value + difference);
        }
    }
}