using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiDropDown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.options.Clear();

        string[] str = { "¥���", "«��", "������", "�Ⱥ�ä", "���ڿϽ�", "ĥ������", "������" };

        List<TMP_Dropdown.OptionData> optionDatas = new List<TMP_Dropdown.OptionData>();
        foreach (var item in str)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData();
            data.text = item;

            optionDatas.Add(data);
        }

        dropdown.options = optionDatas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
