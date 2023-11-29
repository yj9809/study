using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class state : MonoBehaviour
{
    [SerializeField] private EXP level;
    [SerializeField] private TMP_Text[] txt;

    float attack = 0;
    float def = 0;
    float sdef = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attack = ((float)(59 + (2.6 * (level.lv - 1))));
        def = ((float)(25 + (4.2 * (level.lv - 1))));
        sdef = ((float)+ (30 + 1.3 * (level.lv - 1)));

        txt[0].text = Mathf.Floor(attack).ToString();
        txt[1].text = $"0";
        txt[2].text = Mathf.Floor(def).ToString();
        txt[3].text = Mathf.Floor(sdef).ToString();
        txt[4].text = string.Format("{0:N1}", (0.644 +(0.018 * (level.lv - 1))).ToString());
        txt[5].text = $"0";

    }
}
