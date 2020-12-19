using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public float initialTime;
    public float minTime;
    public float maxTime;
    public List<GameObject> CoinsList = new List<GameObject>();
    float timeControl;
    void Update()
    {
        if(GameController.current.PlayerIsAlive) {
            timeControl += Time.deltaTime;

            if(timeControl >= initialTime) {
                Instantiate(CoinsList[Random.Range(0, CoinsList.Count)], 
                    transform.position + new Vector3(0, Random.Range(-1,1), 0), transform.rotation);

                initialTime = Random.Range(minTime, maxTime);
                timeControl = 0;
            }
        }     
    }
}
