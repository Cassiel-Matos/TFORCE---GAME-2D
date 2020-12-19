using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public float minSpeed;
    public float maxSpeed;
    private Transform backPoint;
    private Animator animator;
    private Rigidbody2D rig;

    void Start() {
        backPoint = GameObject.Find("backPoint").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Mesma logica da bala só que para a esquerda
        if(GameController.current.PlayerIsAlive) {
            rig.velocity = new Vector2(-Random.Range(minSpeed, maxSpeed), rig.velocity.y);

            if(transform.position.x < backPoint.position.x)
            {
                Destroy(gameObject);
            }
        }  
    }

    //Metodo para verificar colisao da bala no inimigo
    void OnTriggerEnter2D(Collider2D collision) {
        //Se o inimigo bateu na bala
        if(collision.gameObject.tag == "bullet") {
            GetComponent<CircleCollider2D>().enabled = false;
            GameController.current.AddScore(10); // Adiciona a pontuação após matar o inimigo
            animator.SetTrigger("destroy");
            Destroy(gameObject, 1f);
        }
    }
}
