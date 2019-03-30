using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour {


    public BoxCollider2D bc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Teste");
        }
        else
        {
            bc.isTrigger = true;
            StartCoroutine(Trigger());
        }
    }

    IEnumerator Trigger()
    {
        yield return new WaitForSeconds(0.2f);
        bc.isTrigger = false;
        yield break;
    }
}
