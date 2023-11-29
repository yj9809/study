using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QrTimerE : MonoBehaviour
{
    [SerializeField] private TMP_Text[] txt;
    [SerializeField] private Toggle qrE;

    float time = 180;
    int min, sec;
    
    // Start is called before the first frame update
    void Start()
    {
        txt[0].text = "03";
        txt[1].text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        OnTimer(qrE);
    }

    public void OnTimer(Toggle toggle)
    {
        if (qrE.isOn == true)
        {
            time -= Time.deltaTime;

            min = (int)time / 60;
            sec = ((int)time - min * 60) % 60;

            if (min <= 0 && sec <= 0)
            {
                txt[0].text = 0.ToString();
                txt[1].text = 0.ToString();
            }
            else
            {
                if (sec >= 60)
                {
                    min += 1;
                    sec -= 60;
                }
                else
                {
                    txt[0].text = min.ToString() + " :";
                    txt[1].text = sec.ToString();
                }
            }
        }
        else
        {
            time = 180;
        }
    }
        

    

    
}
