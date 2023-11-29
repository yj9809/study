using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTest2 : MonoBehaviour
{

    public struct Data
    {
        public int number;
        public string regDate;
        public string type;
    }
    List<Data> datas = new List<Data>();

    Dictionary<string, int> dicType = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        dicType.Add("A", 6);
        dicType.Add("B", 12);
        dicType.Add("C", 3);

        string[] regdate = { "2021.05.02", "2021.07.01", "2022.02.19", "2022.02.20" };
        string[] types = { "A", "B", "C", "C" };
        for (int i = 0; i < 4; i++)
        {
            Data d = new Data();
            d.number = i + 1;
            d.regDate = regdate[i];
            d.type = types[i];

            datas.Add(d);
        }

        string toDay = "2022.05.19";
        foreach (var item in datas)
        {
            DateTime d1 = DateTime.Parse(item.regDate);
            DateTime nextd1 = d1.AddMonths(dicType[item.type]);

            DateTime d2 = DateTime.Parse(toDay);
            if ((d2 - nextd1).Days >= 0)
            {
                Debug.Log($"약관 종료, {item.number}");
            }
            else
            {
                Debug.Log($"약관 남음, {item.number}");
            }
        }
        
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
