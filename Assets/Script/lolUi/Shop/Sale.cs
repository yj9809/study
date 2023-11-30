using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sale : MonoBehaviour
{
    [SerializeField] Transform items;
    [SerializeField] Transform dregItme;
    [SerializeField] private Price prices;
    [SerializeField] private Item[] it;

    bool isDrag = false;

    Vector2 startPos;
    Transform target;

    public void OnPointDown()
    {
        
            isDrag = false;
            startPos = transform.position;
            dregItme.gameObject.SetActive(true);
            dregItme.GetComponent<SpriteRenderer>().sprite = items.GetComponent<SpriteRenderer>().sprite;
            items.GetComponent<SpriteRenderer>().enabled = false;

            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            dregItme.position = pos;

    }
    public void OnPointUp()
    {
        items.gameObject.SetActive(true);
        if (target != null)
        {
            for (int i = 0; i < it.Length; i++)
            {
                if (it[i].GetComponent<UnityEngine.UI.Image>().sprite.name == dregItme.GetComponent<SpriteRenderer>().sprite.name)
                {
                   
                }
            }

        }
        else
        {
            items.GetComponent<SpriteRenderer>().enabled = true;
        }
        dregItme.gameObject.SetActive(false);
        isDrag = false;
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
                if (item.collider.gameObject.name.Equals("sale"))
                {
                    
                    target = item.collider.transform;
                    break;
                }
            }
        }
    }
}
