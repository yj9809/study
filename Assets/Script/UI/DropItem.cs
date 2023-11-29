using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] Transform item;
    [SerializeField] Transform dregItme;

    Vector2 startPos;
    Transform target;
    bool isDrag = false;

    public void OnPointDown()
    {
        isDrag = false;
        startPos = transform.position;
        dregItme.gameObject.SetActive(true);
        dregItme.GetComponent<SpriteRenderer>().sprite = this.item.GetComponent<UnityEngine.UI.Image>().sprite;
        this.item.GetComponent<UnityEngine.UI.Image>().enabled = false;
        

        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        dregItme.position = pos;
    }
    public void OnPointUp()
    {
        this.item.gameObject.SetActive(true);
        if(target != null)
        {
            target.GetChild(0).GetComponent<SpriteRenderer>().sprite = dregItme.GetComponent<SpriteRenderer>().sprite;
            target.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            
        }
        else
        {
            this.item.GetComponent<UnityEngine.UI.Image>().enabled = true;
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
    private void Update()
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
    }

    public void OnDrag(PointerEventData eventData)
    {
        isDrag = true;
        Vector2 pos = Camera.main.ScreenToWorldPoint(eventData.position) - transform.position;
        transform.Translate(pos);
    }
    

    //본인이 스크립트를 들고 있는 시스템

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDrag = false;
        startPos = transform.position;
        Vector3 pos = Camera.main.ScreenToWorldPoint(eventData.position);
        pos.z = 0;
        transform.position = pos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.item.gameObject.SetActive(true);
        if (target != null)
        {
            transform.position = target.position;

        }
        else
        {
            startPos = transform.position = startPos;
        }
        isDrag = false;
    }
}
