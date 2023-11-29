using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skillR : MonoBehaviour
{
    [SerializeField] private Image skill;
    [SerializeField] private TMP_Text text;
    [SerializeField] public MP mps;
    [SerializeField] private MpNull mpnull;

    float coolTime = 22f;
    float coolTimeMax = 22f;

    public bool skillCool = true;
    float mp = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && skillCool && mps.mp > mp)
        {
            skillCool = false;
            coolTime = 130f;
            coolTimeMax = 130f;
            skill.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
            mps.MpDown(mp);
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
