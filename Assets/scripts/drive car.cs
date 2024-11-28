using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drivecar : MonoBehaviour
{
   [SerializeField] private RigidBody _front TireRB;
    [SerializeField] private RigidBody _back TireRB;
    [SerializeField] private float _speed =150f;
    private float _moveInput;
    private void Update(){
        moveInput = Input. GetAxisRaw("Horizontal");
         private void  FixedUpdate(){
_front TireRB.AddTorque(_moveInput._speed.Time.fixedDelteTime);
_back TireRB.AddTorque(_moveInput._speed.Time.fixedDelteTime);

         }
    }
}
