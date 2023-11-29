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
    string myName = "������";

    string[] items = { "�Ͱ���", "����", "��", "�����", "����" };
    string[] address = { "����", "���ߴ���", "������ ž", "�ʿ�", "��ũ�� ����" };
    string[] names = { "�ϴ�", "�ҳ�", "õ��", "����", "��", "�ٴ�", "����", "��", "�׸���" };

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
            str += $"[<color=yellow>{names[rend]}</color>]���� ";
            rend = Random.Range(0, address.Length);
            str += $"[\"{address[rend]}\"]���� ";
            rend = Random.Range(0, items.Length);                       
            str += $"\"{items[rend]}\">��(��) ȹ���Ͽ����ϴ�.";

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
