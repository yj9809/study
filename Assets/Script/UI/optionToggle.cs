using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionToggle : MonoBehaviour
{
    [SerializeField] private Toggle[] toggles;
    [SerializeField] private GameObject[] img;
    // Start is called before the first frame update
    void Start()
    {
        int onIndex = 0;
        toggles[onIndex].isOn = true;
        OnToggleChange(toggles[onIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnToggleChange(Toggle toggle)
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            if (toggle.isOn && toggles[i].Equals(toggle))
            {
                img[i].SetActive(true);
            }
            else
            {
                img[i].SetActive(false);
            }
        }
    }
}
