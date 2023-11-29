using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 move = gameObject.transform.position;

        //float x = Input.GetAxis("Horizontal");
        //if (x < 0 )
        //{
        //    move = Vector3.left;
        //}

        //transform.Translate(new Vector3(x, 0f, 0f) * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(x, 0f, 0f) * Time.deltaTime * 5f);
    }
}
