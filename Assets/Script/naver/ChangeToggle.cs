using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToggle : MonoBehaviour
{
    [SerializeField] private Toggle[] toggles;
    [SerializeField] private GameObject[] change;

    // Start is called before the first frame update
    void Start()
    {
        int index = 0;
        toggles[index].isOn = true;
        change[index].SetActive(true);
        OnChangeToggle(toggles[index]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeToggle(Toggle toggle)
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            if (toggle.isOn && toggles[i].Equals(toggle))
            {
                change[i].SetActive(true);
            }
            else
            {
                change[i].SetActive(false);
            }
        }
    }
}
