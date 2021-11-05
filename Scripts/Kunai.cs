using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunai : MonoBehaviour
{
    GameObject player;
    Rigidbody2D myRigi;
    public float Kunai_speed;
    
    // Start is called before the first frame update
    void Awake()
    {
      player = GameObject.Find("Player");  
      myRigi = GetComponent<Rigidbody2D>();
      if (player.transform.localScale.x == 1.0f)
      {
          transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
          myRigi.AddForce(Vector2.right * Kunai_speed, ForceMode2D.Impulse);
      } else if(player.transform.localScale.x == -1.0f)
      {
          transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
          myRigi.AddForce(Vector2.left * Kunai_speed, ForceMode2D.Impulse);
      }
      Destroy(this.gameObject,  5.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            // Destroy(collision.gameObject);
            // Destroy(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
