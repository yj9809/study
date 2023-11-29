using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTest5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Number(new int[] { -2, 3, 0, 2, -5 }));
        Debug.Log(Number(new int[] { -3, -2, -1, 0, 1, 2, 3 }));
        Debug.Log(Number(new int[] { -1, 1, -1, 1 }));


    }

    int Number(int[] number)
    {
        int result = 0;
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = i + 1; j < number.Length; j++)
            {
                for (int k = j + 1; k < number.Length; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                    {
                        result++;
                    }

                }
            }
        }

        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
