using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownControl : MonoBehaviour
{
    [SerializeField] private GameObject[] game;
    [SerializeField] private TMP_Dropdown dropdown;
    
    // Start is called before the first frame update
    void Start()
    {
        dropdown.options.Clear();

        List<TMP_Dropdown.OptionData> option = new List<TMP_Dropdown.OptionData>();

        string[] leng = { "ÇÑ±¹¾î", "English" };

        foreach (var item in leng)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData();
            data.text = item;

            option.Add(data);
        }
        dropdown.options = option;

        dropdown.value = 0;
        OnChang();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChang()
    {
        for (int i = 0; i < game.Length; i++)
        {
            if (dropdown.value == i )
            {
                game[i].SetActive(true);
            }
            else
            {
                game[i].SetActive(false);
            }
        }
    }
}
