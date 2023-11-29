using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HP : MonoBehaviour
{
    [SerializeField] private Image HpIm;
    [SerializeField] private Image HpBg;
    [SerializeField] private TMP_Text txt;
    [SerializeField] private EXP level;

    float hp = 640;
    float hpMax = 640;

    // Start is called before the first frame update
    void Start()
    {        
        HpIm.fillAmount = 1;
        HpBg.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F1))
        {
            hp -= Random.Range(10, 250);
        }

        HpIm.fillAmount = hp / hpMax;
        txt.text = $"{hp} / {hpMax}";
        if (HpIm.fillAmount < HpBg.fillAmount)
        {
            HpBg.fillAmount = Mathf.Lerp(HpBg.fillAmount, HpIm.fillAmount, Time.deltaTime * 2f);
        }

        if (hp < 0)
        {
            txt.text = $"0 / {hpMax}";
        }
    }
}
