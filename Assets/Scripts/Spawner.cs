using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<GameObject> objectsToSpawn = new List<GameObject>();
    public List<GameObject> objs;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    void Start()
    {
        objs = new List<GameObject>();
        currentTimeToSpawn = timeToSpawn;
        SpawnObjects();

    }
    public void SpawnObjects()
    {
        int index = Random.Range(0, objectsToSpawn.Count);
        if (objectsToSpawn.Count>0)
        {
          GameObject obj = Instantiate(objectsToSpawn[index], transform.position, transform.rotation);
            objs.Add(obj);
        }
    }
    private void Update()
    {
        foreach (GameObject obj in objs)
        {
            obj.transform.position += new Vector3(-1, 0, 0)*Time.deltaTime;
                //Check om object er kommet for langt
                //list.remove(obj
        }
        UpdateTimer();
    }
    void UpdateTimer()
    {
        if (currentTimeToSpawn>0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObjects();
            currentTimeToSpawn = timeToSpawn;
        }
    }
    public void RemoveObjects()
    {
        for (int i = objectsToSpawn.Count-1; i >=0; i++)
        {
            GameObject Clone = objectsToSpawn[i];
            objectsToSpawn.RemoveAt(i);
            Destroy(Clone);
        }
    }
}
