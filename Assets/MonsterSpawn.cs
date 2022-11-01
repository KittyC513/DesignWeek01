using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterSpawn : MonoBehaviour
{
    public GameObject monsterPrefab;
    public GameObject player;
    public GameObject spawnPoint;


    bool isSpawned = false;

    public float spawnTime;
    public float spawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(43, -48), 2, Random.Range(48, -49));
            Instantiate(monsterPrefab, randomSpawnPosition, Quaternion.identity);
            Debug.Log(monsterPrefab.transform.position);
        
        } */

        SpawnObject();
    }


    private void SpawnObject()
    {
        //spawn a monster in a random position
        if (!isSpawned)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(43, -48), 2, Random.Range(48, -49));
            Instantiate(monsterPrefab, randomSpawnPosition, Quaternion.identity);
            isSpawned = true;
        }
        else
        {
            CancelInvoke("SpawnObject");
        }

    }
}
