using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class StateView : MonoBehaviour
{
    ItemData data = new ItemData();

    [SerializeField] public GameObject obj;
    [SerializeField] public Image grade;
    [SerializeField] public Image icon;
    [SerializeField] public TMP_Text itemName;
    [SerializeField] public TMP_Text enchantTxt;
    [SerializeField] public TMP_Text levelTxt;

    item item;

    // Start is called before the first frame update
    public void SetUi(ItemData data)
    {

        //enchantTxt.text = data.enchan.ToString();
        //itemName.text = data.icon.name;
        
    }

    // Update is called once per frame
    void Update()
    {
        enchantTxt.text = data.enchan.ToString();
        itemName.text = data.icon.name;
    }
}
