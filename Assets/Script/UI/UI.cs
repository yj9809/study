using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Image hpImage;

    private float hp = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //hp += Time.deltaTime * 0.1f;

        if (Input.GetKeyDown(KeyCode.F1))
        {
            hp += 10;
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            hp -= 10;
        }
        hpImage.fillAmount = hp / 100;
    }
}
