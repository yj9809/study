using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Chatting : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private GameObject chTxt;

    [SerializeField] private TMP_InputField iField;
    [SerializeField] private Color[] colors;
    string myName = "윤제영";

    string[] items = { "귀걸이", "무기", "방어구", "목걸이", "반지" };
    string[] address = { "던전", "수중던전", "도전의 탑", "초원", "오크의 마을" };
    string[] names = { "하늘", "소녀", "천사", "달의", "빛", "바다", "자유", "땅", "그리고" };

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddChatting());
    }
   


    public void OnChattingEnd()
    {
        if (string.IsNullOrEmpty(iField.text)) // string.Empty.Equals(iField.txet)
            return;

        string str = iField.text;
        GameObject obj = Instantiate(chTxt, parent);
        obj.GetComponent<TMP_Text>().text = $"<color=blue>[{myName}]</color>:{str}";
        iField.text = "";        
    }
 
    IEnumerator AddChatting()
    {

        while (true)
        {
            yield return new WaitForSeconds(1);
            string str = string.Empty;

            int rend = Random.Range(0, names.Length);
            str += $"[<color=yellow>{names[rend]}</color>]님이 ";
            rend = Random.Range(0, address.Length);
            str += $"[\"{address[rend]}\"]에서 ";
            rend = Random.Range(0, items.Length);                       
            str += $"\"{items[rend]}\">을(를) 획득하였습니다.";

            GameObject obj = Instantiate(chTxt, parent);
            obj.GetComponent<TMP_Text>().text = str;

            //obj.transform.SetSiblingIndex(0);
        }
    }

    public void DownPos()
    {
        parent.GetComponent<RectTransform>().localPosition = new Vector2(0, (parent.GetComponent<RectTransform>().sizeDelta.y / 2) * 100);
    }
}
