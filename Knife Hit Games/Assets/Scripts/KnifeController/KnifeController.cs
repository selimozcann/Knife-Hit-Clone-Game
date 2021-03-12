using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeedScriptableData;

namespace KnifeControllerSystem
{   
    public class KnifeController : MonoBehaviour
    {

        [SerializeField] private SpeedScriptable _speedScriptable;
        [SerializeField] private Transform _knifePrefab;
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
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Target"))
            {
                Instantiate(_knifePrefab, new Vector2(0, -3.7f), Quaternion.identity);
                transform.SetParent(collision.transform);
                _rb.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else if (collision.gameObject.CompareTag("Knife"))
            {
                Time.timeScale = 0;
                // Continue
            }
        }
    }
}

