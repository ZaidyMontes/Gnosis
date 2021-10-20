using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public LineRenderer line;
    public Transform post1;
    public Transform post2;
    public Transform post3;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Jump"))


        {

            line.positionCount = 3;

            line.SetPosition(0, post1.position);
            line.SetPosition(1, post2.position);
            line.SetPosition(2, post3.position);
        }

    }

}

