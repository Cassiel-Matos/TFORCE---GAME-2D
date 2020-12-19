using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
            GameController.current.GameOverPanel.SetActive(true);
            GameController.current.PlayerIsAlive = false; // Player morreu
            Destroy(collision.gameObject);
        }
    }
}
