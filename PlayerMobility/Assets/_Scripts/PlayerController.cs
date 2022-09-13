using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpforce;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private bool _canjump;
    [SerializeField] private bool _isjumping;
    [SerializeField] private float _downforce;
    void Start()
    {
        
    }

    void Update()
    {

        Vector3 VelocityDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * _speed;

        _rb.velocity = VelocityDirection;

        VelocityDirection.y=_rb.velocity.y;

        if (Input.GetKeyUp(KeyCode.Joystick1Button0) && _canjump)
        {
            _isjumping = true;
            _canjump = false;
            
            _rb.AddForce(Vector3.up * _jumpforce);


            if(transform.position.y<1) _canjump = true;
        
        
        }
    }
}
