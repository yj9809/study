using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    [SerializeField] private Image shop;

    bool open = true;
    // Start is called before the first frame update
    void Start()
    {
        shop.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                shop.gameObject.SetActive(true);
                open = false;
            }
        }
        else if (open == false)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                shop.gameObject.SetActive(false);
                open = true;
            }
        }
        
    }
}
