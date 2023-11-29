using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EXP : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text txt;

    public float lv = 1;
    public float exp = 0;
    public float expMax = 0;

    // Start is called before the first frame update
    void Start()
    {
        lv = 1;
        StartCoroutine(ExpUp());
    }

    // Update is called once per frame
    void Update()
    {
        expMax = 280 + (lv - 1) * 10;
        
    }

    IEnumerator ExpUp()
    {
        while (lv != 18)
        {
            txt.text = lv.ToString();
            yield return new WaitForSeconds(1f);
            exp += Random.Range(10, 60);
            if (exp >= expMax)
            {
                float a = exp - expMax;
                exp = a;
                lv++;
            }
            image.fillAmount = exp / expMax;
            if (lv == 18)
            {
                image.fillAmount = 1;
            }
        }
        
    }


}
