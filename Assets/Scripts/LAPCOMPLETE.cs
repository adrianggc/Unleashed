using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LAPCOMPLETE : MonoBehaviour
{
    public GameObject LAPT;
    public GameObject HALFT;

    public GameObject MinuDisplay;
    public GameObject SecoDisplay;
    public GameObject MiliDisplay;

    public GameObject laptimebox;

    public GameObject Lapcounter;
    public int Lapsdone;

    public float Rawtime;
   

    void OnTriggerEnter()
    {
        Lapsdone += 1;

        Rawtime = PlayerPrefs.GetFloat("Rawtime");
        if (LAPTIMEMANAGER.Rawtime <= Rawtime)
        {
            if (LAPTIMEMANAGER.SecCount <= 9)
            {
                SecoDisplay.GetComponent<Text>().text = "0" + LAPTIMEMANAGER.SecCount + ".";
            }
            else
            {
                SecoDisplay.GetComponent<Text>().text = "" + LAPTIMEMANAGER.SecCount + ".";
            }
            if (LAPTIMEMANAGER.MinCount <= 9)
            {
                MinuDisplay.GetComponent<Text>().text = "0" + LAPTIMEMANAGER.MinCount + ".";
            }
            else
            {
                MinuDisplay.GetComponent<Text>().text = "" + LAPTIMEMANAGER.MinCount + ".";
            }

            MiliDisplay.GetComponent<Text>().text = "" + LAPTIMEMANAGER.MilliCount;
        }
        PlayerPrefs.SetInt("Minsave", LAPTIMEMANAGER.MinCount);
        PlayerPrefs.SetInt("Secsave", LAPTIMEMANAGER.SecCount);
        PlayerPrefs.SetFloat("Milsave", LAPTIMEMANAGER.MilliCount);
        PlayerPrefs.SetFloat("Rawtime", LAPTIMEMANAGER.Rawtime);


        LAPTIMEMANAGER.MinCount = 0;
        LAPTIMEMANAGER.SecCount = 0;
        LAPTIMEMANAGER.MilliCount = 0;
        LAPTIMEMANAGER.Rawtime = 0;
        Lapcounter.GetComponent<Text>().text = "" + Lapsdone;

        if (Lapsdone == 3)
        {
            SceneManager.LoadScene(3);
        }

        HALFT.SetActive(true);
        LAPT.SetActive(false);
    }
}
