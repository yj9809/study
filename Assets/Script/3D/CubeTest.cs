using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = pos.y + 0.5f;
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.red);

        if (Physics.Raycast(pos, transform.forward, out RaycastHit hit, 100f))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
