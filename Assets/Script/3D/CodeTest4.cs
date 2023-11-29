using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTest4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] score = { 2, 1, 1, 2, 3, 1, 2, 3, 1 };
        int answer = 0;
        for (int i = 0; i < score.Length; i++)
        {
            if (score[i] == 1 && i+4 <= score.Length)
            {
                if (score[i+1] == 2 && score[i+2] == 3 && score[i+3] == 1)
                {
                    answer++;
                }
            }
        }

        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
