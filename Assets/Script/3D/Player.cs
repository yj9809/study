using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(x, 0f, z) * Time.deltaTime * 5f);        
    }

    [SerializeField] private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "[ Open Key ]")
        {
            animator.SetBool("on/off", true);
        }

    }
}
