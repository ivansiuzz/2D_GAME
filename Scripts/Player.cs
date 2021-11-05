using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mySpeed;
    Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
     myAnim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");

        if(a > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        } else if(a < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (Mathf.Abs(a) > 0.1f && b ==0)
        {
            myAnim.SetFloat("Run", Mathf.Abs(a));
        }
        else if (Mathf.Abs(b) > 0.1f && a == 0)
        {
            myAnim.SetFloat("Run", Mathf.Abs(b));
        }
        else if (Mathf.Abs(a) > 0.1f && Mathf.Abs(b) > 0.1f)
        {
            myAnim.SetFloat("Run", Mathf.Abs(a));
        }
        else
        {
            myAnim.SetFloat("Run", 0);
        }

        float temp = transform.position.x + a *  Time.deltaTime * mySpeed;
        float tempY = transform.position.y + b * Time.deltaTime * mySpeed;
        transform.position = new Vector3(temp, tempY, transform.position.z);

    }
}
