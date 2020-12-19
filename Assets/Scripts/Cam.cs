using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float Speed; //Velocidade da camera
    private GameObject player; // Player

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(GameController.current.PlayerIsAlive) {
            //Camera seguindo o player
            Vector3 newPosition = new Vector3(player.transform.position.x + 8f, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, Speed * Time.deltaTime); // Efeito suave
        }  
    }
}
