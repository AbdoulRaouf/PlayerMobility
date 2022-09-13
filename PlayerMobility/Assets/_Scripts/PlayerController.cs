using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rb;
    void Start()
    {
        
    }

    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Joystick1Button0)) transform.position+=Vector3.forward;
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _rb.velocity = direction * _speed;
    }
}
