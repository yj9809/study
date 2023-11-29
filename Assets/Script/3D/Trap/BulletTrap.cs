using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrap : MonoBehaviour
{
    [SerializeField] private Bullet bullet= new Bullet();
    [SerializeField] private Transform parent;    

    float timer = 2f;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        
        if (time > timer)
        {
            Instantiate(bullet, parent);
            time = 0;
        }
    }
}
