using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

    private bool isPinned = false;
    private float speed;
    
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = PlayerPrefs.GetFloat("Pin");
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            this.enabled = false;
            Score.PinCount++;
            isPinned = true;
        }   if (col.tag == "Pin" )
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
