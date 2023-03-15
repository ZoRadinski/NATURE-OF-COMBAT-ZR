using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;





public class CostDisplayer : MonoBehaviour
{
    public int towerID;
    public int towerCost;

    void Start()
    {
        towerCost = GameManager.instance.spawner.TowerCost(towerID);
        GetComponent<TextMeshProUGUI>().text = towerCost.ToString();   
    }
}
