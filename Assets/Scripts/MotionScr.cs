using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScr : MonoBehaviour
{
    //[SerializeField] private Transform _terget;
    [SerializeField] private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.back);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Movement(Vector3.up);
        }
    }

    private void Movement(Vector3 direction)
    {
        transform.position = transform.position + direction * _speed 
             * Time.deltaTime
            ;
    }
}
