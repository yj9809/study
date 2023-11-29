using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lodig : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        txt.text = ((int)slider.value).ToString() + "%";
    }
}
