using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake() { instance = this; }

    public Spawner spawner;
    public healthSystem health;
    public CurrencySystem currency;

    void Start()
    {
        GetComponent<healthSystem>().Init();
        GetComponent<CurrencySystem>().Init();

        StartCoroutine(WaveStartDelay());
    }

    IEnumerator WaveStartDelay()
    {
        //Wait for X seconds
        yield return new WaitForSeconds(2f);
        //Start the enemy spawning
        GetComponent<EnemySpawner>().StartSpawning();
    }

}