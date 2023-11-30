using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Price : MonoBehaviour
{
    [SerializeField] private TMP_Text txt;

    int money = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoneyUp());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Purchase(int price)
    {
        int okay = 0;
        if (price <= money)
        {
            okay = 1;
        }
        else
        {
            okay = 0;
        }

        return okay;
    }

    public int MoneyDown(int price)
    {
        money -= price;
        txt.text = money.ToString();
        return price;
    }
    IEnumerator MoneyUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            money += Random.Range(10, 300);
            txt.text = money.ToString();
        }
    }
}
