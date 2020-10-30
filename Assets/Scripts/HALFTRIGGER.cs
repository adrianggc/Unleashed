using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HALFTRIGGER : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LAPCompleteT;
    public GameObject HalfLAPT;
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        LAPCompleteT.SetActive(true);
        HalfLAPT.SetActive(false);
    }
}
