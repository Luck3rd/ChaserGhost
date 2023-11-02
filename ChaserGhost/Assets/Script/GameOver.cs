using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private bool gameOver;
    private bool ignoreTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

void OnTriggerEnter2D(Collider2D target) {

        if(target.tag == "Player") 
        {
            SceneManager.LoadScene("GameOver");
        } 
}

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }      
}
