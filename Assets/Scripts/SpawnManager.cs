using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public static int enemyCount = 0;

    [SerializeField] private GameObject enemyPrefab;

    private float x = 0;
    private float y = 0;
    private float z = 0;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            x += 1;
            y += 1;
            z += 1;
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(x, y, z), Quaternion.identity);
        }

    }
}
