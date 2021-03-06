using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;

	// Use this for initialization
	void Start () {
        speed = 5.1f;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * 250);
        }
	}

    void resetPosition()
    {
        Debug.Log("SPIKED RECIEVED!");
        transform.SetPositionAndRotation(new Vector3(-5.46f, 1.46f, 0), Quaternion.identity);
    }
}
