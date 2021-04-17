using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpeedScriptableData
{
    [CreateAssetMenu(menuName = "ScriptableObject/SpeedScriptable")]
    public class SpeedScriptable : ScriptableObject
    {
        [Header("BoardRotateSpeed")]
        [SerializeField] private float _boardRotateSpeed;
        public float BoardRotateSpeedProperty { get { return _boardRotateSpeed; } }

        [Header("KnifeControllerSpeed")]
        [SerializeField] private float _knifeControllerSpeed;
        public float  KnifeSpeedProperty { get { return _knifeControllerSpeed; } }
    }
}

