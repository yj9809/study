using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MP : MonoBehaviour
{
    [SerializeField] private Image mpImage;
    [SerializeField] private Image mpBgImage;
    [SerializeField] private TMP_Text text;

    public float mp = 1000f;
    float mpMax = 1000;
    // Start is called before the first frame update
    void Start()
    {
        mpImage.fillAmount = 1;
        mpBgImage.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (mpImage.fillAmount < mpBgImage.fillAmount)
        {
            mpBgImage.fillAmount = Mathf.Lerp(mpBgImage.fillAmount, mpImage.fillAmount, Time.deltaTime * 2f);
        }
    }
    public float MpDown(float mps)
    {
        mp -= mps;
        mpImage.fillAmount = mp / mpMax;        
        text.text = $"{mp} / {mpMax}";

        if (mp < 0)
        {
            text.text = $"0 / {mpMax}";
        }
        return mps;
    }


}
