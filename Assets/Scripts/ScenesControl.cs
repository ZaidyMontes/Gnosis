using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControl : MonoBehaviour
{
    public GameObject codigo1;

    public Bridge yellowBridge;
    public GreenBridge greenBridge;
    public RedBridge redBridge;
    public VioletBridge violetBridge;

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
        if (tag == "Puzzle1")
        {
            SceneManager.LoadScene(2);
        }
        else if (tag == "Puzzle2")
        {
            SceneManager.LoadScene("screws");

        }
        else if (tag == "Puzzle3")
        {
            SceneManager.LoadScene("Jigsaw");
        }
    }
    public void Complete()
    {
        if (yellowBridge.instancia1 == 1 && greenBridge.instancia1 == 1 && redBridge.instancia1 == 1 && violetBridge.instancia1 == 1)
        {
            Instantiate(codigo1);


        }
    }

    public void Anotado()
    {

        SceneManager.LoadScene(1);

    }
}