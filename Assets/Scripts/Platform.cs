using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    private Transform backPoint;

    void Start()
    {
        backPoint = GameObject.Find("backPoint").GetComponent<Transform>();
    }

    void Update()
    {
        if(transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
        
    }
}
