using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float initialTime;
    public float minTime;
    public float maxTime;
    public List<GameObject> EnemiesList = new List<GameObject>();
    float timeControl;
    void Update()
    {
        if(GameController.current.PlayerIsAlive) {
            timeControl += Time.deltaTime;

            if(timeControl >= initialTime) {
                Instantiate(EnemiesList[Random.Range(0, EnemiesList.Count)], 
                    transform.position + new Vector3(0, Random.Range(-2,2), 0), transform.rotation);

                initialTime = Random.Range(minTime, maxTime);
                timeControl = 0;
            }
        }   
    }
}
