using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] Transform items;
    [SerializeField] Transform dregItme;
    [SerializeField] TMP_Text txt;
    [SerializeField] private Price prices;

    bool isDrag = false;

    public int price = 0;
    int check = 1;
    Vector2 startPos;
    Transform target;

    public void OnPointDown()
    {
        if (check == prices.Purchase(price))
        {
            isDrag = false;
            startPos = transform.position;
            dregItme.gameObject.SetActive(true);
            dregItme.GetComponent<SpriteRenderer>().sprite = items.GetComponent<UnityEngine.UI.Image>().sprite;
            //items.GetComponent<UnityEngine.UI.Image>().enabled = false;

            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            dregItme.position = pos;
        }
    }
    public void OnPointUp()
    {
        if (check == prices.Purchase(price))
        {
            items.gameObject.SetActive(true);
            if (target != null && target.GetChild(0).GetComponent<SpriteRenderer>().enabled != true)
            {
                target.GetChild(0).GetComponent<SpriteRenderer>().sprite = dregItme.GetComponent<SpriteRenderer>().sprite;
                target.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                prices.MoneyDown(price);                

            }
            else
            {
                items.GetComponent<UnityEngine.UI.Image>().enabled = true;
            }
            dregItme.gameObject.SetActive(false);
            isDrag = false;
        }
    }
    public void OnDrag()
    {
        isDrag = true;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - dregItme.position;
        dregItme.Translate(pos);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDrag)
        {
            RaycastHit2D[] hit =
                Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);

            target = null;
            foreach (var item in hit)
            {
                if (item.collider.gameObject.name.Equals("ItemBG"))
                {
                    target = item.collider.transform;
                    break;
                }
            }
        }

        txt.text = price.ToString();
    }


}
