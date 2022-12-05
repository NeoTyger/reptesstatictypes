using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    private UIManager _uiManager;

    //private float timer = 0;


    private void OnEnable()
    {
        //timer += Time.deltaTime;

        SpawnManager.enemyCount++;
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        _uiManager.UpdateEnemyCount();
        Destroy(gameObject, 10);
        

        /*if (timer >= 10)
        {
            Destroy(gameObject);
            timer = 0;
        }*/
    }

    private void OnDisable()
    {
        SpawnManager.enemyCount--;
        _uiManager.UpdateEnemyCount();
    }
}
