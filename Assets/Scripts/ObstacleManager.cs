using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public float spawnStartAt;
    public float spawnEvery;

    public Vector3 SpawnPoint;
    public float distanceBetweenObstacles = 5;

    public GameObject obstaclePoolGameObject;
    public List<GameObject> obstaclePool;

    public bool debug = false;

    void Start()
    {
        int childrenCount = obstaclePoolGameObject.transform.childCount;

        for (int i = 0; i < childrenCount; ++i)
        {
            obstaclePool.Add(obstaclePoolGameObject.transform.GetChild(i).gameObject);
        }

        InvokeRepeating("Repeater", spawnStartAt, spawnEvery);
    }

    void Update()
    {
        if (debug)
        {
            SpawnWave(obstaclePool);
            debug = false;
        }
    }

    void Repeater()
    {
        SpawnWave(obstaclePool);
    }

    private void SpawnWave(List<GameObject> pool)
    {
        float randomValue = Random.value;

        List<GameObject> objects = new List<GameObject>();

        int amountToSpawn = 0;

        if (randomValue < .45f) // 45% of the time
        {
            amountToSpawn = 1;
        }
        else if (randomValue < .9f) // 45% of the time
        {
            amountToSpawn = 2;
        }
        else // 10% of the time
        {
            amountToSpawn = 3;
        }

        objects = FindAvailable(obstaclePool, amountToSpawn);

        Spawn(objects, SpawnPoint);
    }

    private void Spawn(List<GameObject> objectsToSpawn, Vector3 spawnPosition)
    {
        Vector3 position = spawnPosition;

        if(objectsToSpawn != null && objectsToSpawn.Count != 0)
        {
            for (int i = 0; i < objectsToSpawn.Count; i++)
            {
                objectsToSpawn[i].GetComponent<Obstacle>().RandomizeColor();
                objectsToSpawn[i].GetComponent<ObstacleMove>().SetMoveBool(true);
                objectsToSpawn[i].transform.position = spawnPosition;
                objectsToSpawn[i].GetComponent<Obstacle>().SetActive();

                float newZ = spawnPosition.z + distanceBetweenObstacles;

                spawnPosition = new Vector3(spawnPosition.x, spawnPosition.y, newZ);
            }
        }
    }

    private List<GameObject> FindAvailable(List<GameObject> pool, int amountNeeded)
    {
        int amount = amountNeeded;

        List<GameObject> AvailableObjects = new List<GameObject>();

        for (int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].transform.GetChild(0).gameObject.activeSelf)
            {
                AvailableObjects.Add(pool[i]);

                amount = amount - 1;
            }

            if (amount == 0)
            {
                break;
            }
        }

        if (amount == 0)
        {
            return AvailableObjects;
        }
        else
        {
            return null;
        }
    }
}
