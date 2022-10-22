using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingLeafs : MonoBehaviour
{
    public GameObject leaf;
    public int areaSize = 5;

    private int timer;
    private int spawnPointX;
    private Vector3 spawnPosition;
    private Vector3 spawnLocation;
    private float elapsedTime;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timer)
        {
            Spawn();
            elapsedTime = 0;
        }
    }

    void Spawn()
    {
        timer = Random.Range(3, 5);
        spawnPointX = Random.Range(-areaSize, areaSize);

        spawnPosition = gameObject.transform.TransformPoint(spawnLocation);
        spawnLocation = new Vector3(spawnPointX, 0, 0);
        Instantiate(leaf, spawnPosition, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(gameObject.transform.position - new Vector3(areaSize, 0), gameObject.transform.position + new Vector3(areaSize, 0));
    }

}
