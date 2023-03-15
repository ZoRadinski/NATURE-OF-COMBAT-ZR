using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class healthSystem : MonoBehaviour
{
    public TextMeshProUGUI txt_healthCount;
    public int healthCount;
    public int defaultHealthCount;

    public GameObject publicObject;


    //reset life
    public void Init()
    {
        healthCount = defaultHealthCount;
        //txt_healthCount.text = healthCount.ToString();
       
    }

    public void LoseHealth()
    {
        if (healthCount < 1)
            return;

        healthCount = healthCount - 1;
        txt_healthCount.text = healthCount.ToString();

        CheckHealthCount();
    }

    void CheckHealthCount()
    {
        if(healthCount<=0)
        {
            SceneManager.LoadScene("Lose");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            LoseHealth();
        }
    }
}
