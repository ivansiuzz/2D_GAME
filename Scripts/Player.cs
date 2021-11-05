using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Horizontal");

        if(a > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        } else if(a < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        float temp = transform.position.x + a *  Time.deltaTime * mySpeed;
        transform.position = new Vector3(temp, transform.position.y, transform.position.z);

    }
}
