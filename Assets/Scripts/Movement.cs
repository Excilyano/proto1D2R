using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;

    void Start ()
    {
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);
		Vector3 rotation = new Vector3 (0.0f, moveHorizontal, 0.0f);

        transform.Translate (movement * speed);
		transform.Rotate (rotation * 3f);
    }
}
