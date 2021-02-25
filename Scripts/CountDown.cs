using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    //Set max time
    public float timer = 300;
    public Text textUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    //Displaying Text UI
       timer -= Time.deltaTime;
        textUI.text = $"Timer {Mathf.Round(timer)}";

       if (timer <= 0)
        {
                timer = 0;
                //Restart Scene if timer = 0
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         }
        
    }
}