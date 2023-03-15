using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencySystem : MonoBehaviour
{
    //fields
    public TextMeshProUGUI txt_Currency;
    public int defaultCurrency;
    public int currency;


    //methods
public void Init()
    {
        currency = defaultCurrency;

    }

    public void Gain(int val)
    {
        currency += val;
        UpdateUI();
    }

    public bool Use(int val)
    {
        if(EnoughCurrency(val))
        {
            currency -= val;
            UpdateUI();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool EnoughCurrency(int val)
    {
        if (val <= currency)
            return true;
        else
            return false;
    }

    void UpdateUI()
    {
        txt_Currency.text = currency.ToString();
    }

    public void usetest()
    {
        Debug.Log(Use(30));
    }
}
