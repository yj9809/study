using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class ImageChange : MonoBehaviour
{
    [SerializeField] string url = "https://scontent-ssn1-1.xx.fbcdn.net/v/t1.6435-9/67463123_366133984065466_6327272728713756672_n.jpg?stp=dst-jpg_p526x296&_nc_cat=100&ccb=1-7&_nc_sid=dd63ad&_nc_ohc=t9DrNp8udX8AX_tMmn5&_nc_ht=scontent-ssn1-1.xx&oh=00_AfBFkDK0vCsbjP9EQP7z9OsOh4TJAdCCmiciH_4LOGQkkg&oe=65744B11";
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(GetTexture());
        }
    }

    IEnumerator GetTexture()
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("다운로드 실패!!!");
        }
        else
        {
            GetComponent<RawImage>().texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        }
    }

    public void OnChangeImage()
    {
        StartCoroutine(GetTexture());
    }
}
