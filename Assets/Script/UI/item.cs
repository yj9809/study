using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class item : MonoBehaviour
{
    ItemData data = new ItemData();

    [SerializeField] private GameObject obj;
    [SerializeField] public Image icon;
    [SerializeField] public TMP_Text enchantTxt;
    [SerializeField] private TMP_Text levelTxt;


    StateView sv;
    ItemControl ic;

    private int count = 1;

    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            enchantTxt.text = $"{count}";
        }
    }

   public void SetData(ItemData data, ItemControl ic)
    {
        this.ic = ic;
        this.data = data;

        obj.SetActive(true);
        Image bg = GetComponent<Image>();
        bg.color = new Color(1f, 1f, 1f, 1f);
        bg.sprite = ic.frame[(int)data.grade];
        levelTxt.text = $"{data.level}";
        //icon.sprite = ic.armorSprites[Random.Range(0, ic.armorSprites.Length)];

        if (data.enchan != 0)
        {
            enchantTxt.text = $"+{data.enchan}";
        }
        else
        {
            enchantTxt.text = string.Empty;
        }
        if (data.level != 0)
        {
            levelTxt.text = $"+{data.level}";
        }
        else
        {
            levelTxt.text = string.Empty;
        }

    }

    public void SetStateView(StateView sv)
    {
        this.sv = sv;
        //sv.obj.SetActive(false);
    }

    public void Empty()
    {
        obj.SetActive(false);
    }

    public void OnSetStateView()
    {
        sv.obj.SetActive(true);
        sv.SetUi(this.data);
    }
}
