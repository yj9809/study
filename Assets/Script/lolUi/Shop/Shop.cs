using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    [SerializeField] private Image shop;
    [SerializeField] private Image sale;

    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                shop.gameObject.SetActive(false);
                sale.gameObject.SetActive(false);
                open = false;
            }
        }
        else if (open == false)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                shop.gameObject.SetActive(true);
                sale.gameObject.SetActive(true);
                open = true;
            }
        }
        
    }
}
