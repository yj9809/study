using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skillF : MonoBehaviour
{
    [SerializeField] private Image skill;
    [SerializeField] private TMP_Text text;

    
    float coolTime = 16f;
    float coolTimeMax = 16f;

    public bool skillCool = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && skillCool)
        {
            skillCool = false;
            coolTime = 300f;
            coolTimeMax = 300f;
            skill.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
        }
        coolTime -= Time.deltaTime;

        skill.fillAmount = coolTime / coolTimeMax;
        text.text = ((int)coolTime).ToString();
        if (coolTime < 1)
        {
            text.text = string.Format("{0:N1}", coolTime);
        }

        if (coolTime < 0)
        {
            skillCool = true;
            skill.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
        }
    }
}
