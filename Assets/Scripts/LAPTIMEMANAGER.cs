using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LAPTIMEMANAGER : MonoBehaviour
{
    public static int MinCount;
    public static int SecCount;
    public static float MilliCount;
    public static string MilliDsiplay;

    public GameObject MinBox;
    public GameObject SecBox;
    public GameObject MilliBox;

    public static float Rawtime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        Rawtime += Time.deltaTime;
        MilliDsiplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDsiplay;

        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecCount += 1;
        }

        if (SecCount <= 9)
        {
            SecBox.GetComponent<Text>().text = "0" + SecCount + ".";
        }
        else
        {
            SecBox.GetComponent<Text>().text = "" + SecCount + ".";
        }

        if (SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if (MinCount <= 9)
        {
            MinBox.GetComponent<Text>().text = "0" + MinCount + ":";
        }
        else
        {
            MinBox.GetComponent<Text>().text = "" + MinCount + ":";
        }

    }
}
