using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelTask1 : MonoBehaviour

{
    
    
    public DoorController open;
    public TextMeshProUGUI password;
    public TextMeshProUGUI display;

    public AudioClip approved;
    public AudioClip denied;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
        password.text = "1234";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddNumber(string number)
    {
        if (display.text.Length >= 4)
        {
            return;
        }
        display.text += number;
    }
    public void EraseDisplay()
    {
        display.text = "";
    }

    public void CheckPassword()
    {
        if (display.text.Equals(password.text))
        {

            
            audioSource.PlayOneShot(approved);
            display.color = Color.green;
            display.text = "Correcto";
            
            gameObject.SetActive(false);
            open.Open();




        }
        else
        {
            audioSource.PlayOneShot(denied);
            display.text = "Error";
        }
    }
}
