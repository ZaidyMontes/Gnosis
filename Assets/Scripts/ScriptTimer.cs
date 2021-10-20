using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptTimer : MonoBehaviour
    
{
    public Text timesegundos;
    public Text timeminutos;
    private float segundos = 60f;
    private float minutos = 10f;

    // Start is called before the first frame update
    void Start()
    {
        timesegundos.text = "" + segundos;
        timeminutos.text = " " + minutos;
    }

    // Update is called once per frame
    void Update()
    {
        Metodo1();
        if(minutos <= 0)
        {
            segundos = 0;
            timesegundos.text = " " + segundos.ToString("f0");
            minutos = 0;
            timeminutos.text = " " + minutos.ToString("f0");
            SceneManager.LoadScene(0);
        }
       

    }
   

    public void Metodo1()
    {
        segundos = segundos - Time.deltaTime;
        timesegundos.text = " " + segundos.ToString("f0");
        if (segundos <= 0)
        {
            minutos = minutos - 1;
            timeminutos.text = " " + minutos.ToString("f0");
            segundos = 60f;
        }
        
    }


}
