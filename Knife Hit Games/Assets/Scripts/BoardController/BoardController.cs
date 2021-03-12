using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeedScriptableData;

namespace BoardControllerSystem
{
    public class BoardController : MonoBehaviour
    {
        [SerializeField] private SpeedScriptable _speedScriptable;
        private void Update()
        {
            transform.Rotate(Vector3.back * _speedScriptable.BoardRotateSpeedProperty * Time.deltaTime );
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Knife"))
            {
                collision.transform.SetParent(transform);
            }
        }
    }
}

