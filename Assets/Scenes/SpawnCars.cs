using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    public float spawnTimer;
    public Vector3 offset;
    public Transform player;

    void Start()
    {

    }

    float time_left = 0;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        Debug.Log(time_left);
        time_left -= Time.deltaTime;
        if (time_left < 0)
        {
            time_left = spawnTimer;
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], transform.position, Random.rotation);

        }
    }
}
