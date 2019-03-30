using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwap : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Physics2D.gravity = new Vector2(-9.81f, 0f);
        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Physics2D.gravity = new Vector2(0f, -9.81f);
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Physics2D.gravity = new Vector2(2f, 9.81f);
        }else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(9.81f, 0f);
        }
		
	}
}
