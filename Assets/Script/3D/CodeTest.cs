using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTest : MonoBehaviour
{    
        List<char> chars = new List<char>();
        char[] s = { 'a',  'k', 'k', 's' };
        char[] skips = { 'w', 'b', 'q', 'd' };
        int nextIndex = 5;
    // Start is called before the first frame update
    void Start()
    {
        char ch = ' ';
        int index = 97;

        while (ch != 'z')
        {
            ch = (char)index;
            chars.Add(ch);
            index++;
        }

        string str = "";
        for (int i = 0; i < s.Length; i++)
        {
            str += SkipChar(StartIndex(s[i]));
        }
        Debug.Log(str);
    }

    int StartIndex(char c)
    {
        for (int i = 0; i < chars.Count; i++)
        {
            if (c == chars[i])
            {
                return i;
            }
        }
        return -1;
    }
    
    char SkipChar(int sIndex)
    {
        int index = 0;
        while (true)
        {
            bool isSkip = false;
            for (int j = 0; j < skips.Length; j++)
            {
                if (sIndex >= chars.Count)
                    sIndex = 0;

                if (chars[sIndex].Equals(skips[j]))
                {
                    isSkip = true;
                    break;
                }
            }
            if (isSkip)
            {
                sIndex++;
                continue;
            }
            else if (index == nextIndex)
            {
                return chars[sIndex];
            }
            index++;
            sIndex++;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
