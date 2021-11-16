using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public bool CanMove = false;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity = new Vector2(0, 1 * speed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.velocity = new Vector2(0, -1 * speed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-1 * speed * Time.deltaTime, 0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(1 * speed * Time.deltaTime, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            CanMove = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        CanMove = false;
    }
}
