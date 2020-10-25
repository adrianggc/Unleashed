using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject Laptimer;
    public GameObject Carcontrols;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(2);
        CountDown.SetActive(false);
        Laptimer.SetActive(true);
        Carcontrols.SetActive(true);


    }
}
