using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IDcheck : MonoBehaviour
{
    [SerializeField] private TMP_InputField[] txt;
    [SerializeField] private TMP_InputField number;

    string id = "wasd@naver.com";
    string pass = "12345";
    string num = "980905";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnIdCheck()
    {
        if (txt[0].text == id && txt[1].text == pass)
        {
            Debug.Log("로그인 성공");
        }
        else
        {
            Debug.Log("로그인 실패");
        }
    }
    public void OnNumber()
    {
        if (number.text == num)
        {
            Debug.Log("로그인 성공");
        }
        else
        {
            Debug.Log("로그인 실패");
        }
    }
}
