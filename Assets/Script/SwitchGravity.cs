using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour {

    private Rigidbody2D rb;
    private PlayerController player;

    private bool top;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<PlayerController>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
        }       
	}

    void Rotation()
    {
        if(top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        player.facinRight = !player.facinRight;
        top = !top;
    }
}
