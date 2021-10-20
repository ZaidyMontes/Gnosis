using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCube : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 input;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.deltaTime;
    }
}
