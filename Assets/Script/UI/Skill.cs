using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    public Image img;
    public TMPro.TMP_Text txt;

    float v = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            v = 1f;
        }

        v -= Time.deltaTime / 5;
        img.fillAmount = v;

        if (v < 0)
        {
            v = 1f;
        }
        //if (v < 0 && img.fillClockwise == false)
        //{
        //    v = 1f;
        //    img.fillClockwise = true;
        //}
        //else if (v < 0 && img.fillClockwise == true)
        //{
        //    v = 1f;
        //    img.fillClockwise = false;
        //}
        

        txt.text = ((int)(v + (5f * v))).ToString();
        
    }
}
