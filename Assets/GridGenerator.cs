using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public int rows = 5;
    public int columns = 5;
    public float spacing = 1f;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        Vector3 startPos = transform.position;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector3 spawnPos = startPos + new Vector3(col * spacing, -row * spacing, 0);
                GameObject prefabToSpawn = Random.Range(0, 2) == 0 ? prefab1 : prefab2;
                Instantiate(prefabToSpawn, spawnPos, Quaternion.identity, transform);
            }
        }
    }
}
