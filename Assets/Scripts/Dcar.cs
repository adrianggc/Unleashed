using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dcar : MonoBehaviour
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

    public int ChckTrack;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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




    }
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DCar")
        {
            GetComponent<BoxCollider>().enabled = false;
            ChckTrack += 1;

            if (ChckTrack == 14)
            {
                ChckTrack = 0;
            }
            yield return new WaitForSeconds(1);
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
