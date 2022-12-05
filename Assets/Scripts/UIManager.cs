using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI activeEnemiesText;

    public void UpdateEnemyCount()
    {
        activeEnemiesText.text = "Enemies: " + SpawnManager.enemyCount;
    }
}
