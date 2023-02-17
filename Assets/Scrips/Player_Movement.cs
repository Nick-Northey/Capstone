using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player_Movement : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 target;

    void Start()
    {
        target= transform.position;
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetMouseButtonDown(0)) 
        { 
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

}
