using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(tag == "Puzzle1") {
            SceneManager.LoadScene("Conect");
        }
        else if(tag == "Puzzle2")
        {
            SceneManager.LoadScene("screws");

        }
        else if(tag == "Puzzle3")
        {
            SceneManager.LoadScene("Jigsaw");
        }
    }
}
