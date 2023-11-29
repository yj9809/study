using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTest3 : MonoBehaviour
{
    int k = 3;
    int[] score = { 10, 100, 20, 150, 1, 100, 200 };
    List<int> hall = new List<int>();
    // Start is called before the first frame update
    void Start()
    {        
        for (int i = 0; i < score.Length; i++)
        {
            hall.Add(score[i]);
            hall.Sort(new Comparison<int>((n1, n2) => n2.CompareTo(n1)));                   
            if (hall.Count > k)
            {
                hall.RemoveAt(hall.Count - 1);
            }
            string s = " ";
            foreach (var item in hall)
            {
                s += item.ToString()+ " ";
            }

            Debug.Log($"score {score[i]}, 명예의 전당[{s}], 발표 점수 {hall[hall.Count-1]}");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
