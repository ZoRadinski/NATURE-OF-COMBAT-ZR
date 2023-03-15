using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class HealthBox : MonoBehaviour
{
    public TextMeshProUGUI txt_health;
    public int health;
    public int defaultHealth;


    // Start is called before the first frame update
    void Start()
    {
        health = defaultHealth;
        txt_health.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealthCount();
    }

    void CheckHealthCount()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }

    }


    public void LoseHealth()
    {
        if (health < 1)
            return;

        health--;
        txt_health.text = health.ToString();

        CheckHealthCount();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            LoseHealth();
        }
    }
}
