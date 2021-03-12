using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeedScriptableData;

namespace KnifeControllerSystem
{   
    public class KnifeController : MonoBehaviour
    {

        [SerializeField] private SpeedScriptable _speedScriptable;
        private Rigidbody2D _rb;
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            if (IsTouchMouse())
            {
                _rb.velocity = Vector2.up * _speedScriptable.KnifeSpeedProperty;
            }
        }
        private bool IsTouchMouse()
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}

