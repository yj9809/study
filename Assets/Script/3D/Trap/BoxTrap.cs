using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrap : MonoBehaviour
{
    Vector3 v;
    float zmove = 5f;
    float xmove = -5f;
    float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        //v = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 vec=v;
        //vec.z += zmove * Mathf.Sin(Time.time * speed);
        //vec.x += xmove * Mathf.Sin(Time.time * speed);
        //transform.position=vec;
    }

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();
        if(p != null)
        {
            //Destroy(other.gameObject);
            
        }

    }
}
