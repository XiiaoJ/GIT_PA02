using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnObject1, SpawnObject2, SpawnObject3, SpawnObject4;

    public float spawnRate = 1f;

    float nextSpawn = 0f;
    float PositionX;

    int whatToSpawn;

    // Update is called once per frame
    void Update()
    {
        PositionX = Random.Range(-1.5f, 1.5f);
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 5);

            switch (whatToSpawn)
            {
                case 1:
                    this.transform.position = new
                        Vector3(PositionX, transform.position.z);
                    Instantiate(SpawnObject1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    this.transform.position = new
                        Vector3(PositionX, transform.position.z);
                    Instantiate(SpawnObject2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    this.transform.position = new
                        Vector3(PositionX, transform.position.z);
                    Instantiate(SpawnObject3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    this.transform.position = new
                        Vector3(PositionX, transform.position.z);
                    Instantiate(SpawnObject4, transform.position, Quaternion.identity);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }
    }
}
