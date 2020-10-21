using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Races : MonoBehaviour
{
    public string Race1Scene;
    public string Race2Scene;
    public string Race3Scene;
    public string MainMenuScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RACE1()
    {
        SceneManager.LoadScene(Race1Scene);
    }

    public void RACE2()
    {
        SceneManager.LoadScene(Race2Scene);
    }

    public void RACE3()
    {
        SceneManager.LoadScene(Race3Scene);
    }

    public void BACK()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
}
