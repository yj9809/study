using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MpNull : MonoBehaviour
{
    float cooltime = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnText()
    {
        gameObject.SetActive(true);
        cooltime -= Time.deltaTime;
        if (cooltime < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
