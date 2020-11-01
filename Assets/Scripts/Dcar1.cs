using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dcar1 : MonoBehaviour
{

    public GameObject marker;
    public GameObject chck01;
    public GameObject chck02;
    public GameObject chck03;
    public GameObject chck04;
    public GameObject chck05;
    public GameObject chck06;
    public GameObject chck07;
    public GameObject chck08;
    public GameObject chck09;
    public GameObject chck10;
    public GameObject chck11;
    public GameObject chck12;
    public GameObject chck13;
    public GameObject chck14;
    public GameObject chck15;
    public GameObject chck16;
    public GameObject chck17;
    public GameObject chck18;
    public GameObject chck19;
    

    public int ChckTrack;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // car AI follows the mark and checkpoint patterns
        if (ChckTrack == 0)
        {
            marker.transform.position = chck01.transform.position;
        }
        if (ChckTrack == 1)
        {
            marker.transform.position = chck02.transform.position;
        }
        if (ChckTrack == 2)
        {
            marker.transform.position = chck03.transform.position;
        }
        if (ChckTrack == 3)
        {
            marker.transform.position = chck04.transform.position;
        }
        if (ChckTrack == 4)
        {
            marker.transform.position = chck05.transform.position;
        }
        if (ChckTrack == 5)
        {
            marker.transform.position = chck06.transform.position;
        }
        if (ChckTrack == 6)
        {
            marker.transform.position = chck07.transform.position;
        }
        if (ChckTrack == 7)
        {
            marker.transform.position = chck08.transform.position;
        }
        if (ChckTrack == 8)
        {
            marker.transform.position = chck09.transform.position;
        }
        if (ChckTrack == 9)
        {
            marker.transform.position = chck10.transform.position;
        }
        if (ChckTrack == 10)
        {
            marker.transform.position = chck11.transform.position;
        }
        if (ChckTrack == 11)
        {
            marker.transform.position = chck12.transform.position;
        }
        if (ChckTrack == 12)
        {
            marker.transform.position = chck13.transform.position;
        }
        if (ChckTrack == 13)
        {
            marker.transform.position = chck14.transform.position;
        }
        if (ChckTrack == 14)
        {
            marker.transform.position = chck15.transform.position;
        }
        if (ChckTrack == 15)
        {
            marker.transform.position = chck16.transform.position;
        }
        if (ChckTrack == 16)
        {
            marker.transform.position = chck17.transform.position;
        }
        if (ChckTrack == 17)
        {
            marker.transform.position = chck18.transform.position;
        }
       



    }
    IEnumerator OnTriggerEnter(Collider collision)
    {// to return to the first checkpoint
        if (collision.gameObject.tag == "Dcar1")
        {
            GetComponent<BoxCollider>().enabled = false;
            ChckTrack += 1;

            if (ChckTrack == 18)
            {
                ChckTrack = 0;
            }
            yield return new WaitForSeconds(1);
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
