using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Speed;
    
    void Start() {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        //Movimentar a bola para direita
        transform.Translate(Vector3.right * Speed * Time.deltaTime)        ;
    }
}
