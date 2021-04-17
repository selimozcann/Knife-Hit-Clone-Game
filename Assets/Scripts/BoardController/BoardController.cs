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
    }
}

