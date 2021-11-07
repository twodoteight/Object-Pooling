using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private ObjectPooler objectPooler;
    private List<string> poolList;
    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.instance;
        poolList = new List<string>(objectPooler.poolDictionary.Keys);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objectPooler.SpawnFromPool(poolList[Random.Range(0, 2)], transform.position, Quaternion.identity);
    }
}
