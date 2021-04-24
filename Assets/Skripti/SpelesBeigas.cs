using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelesBeigas : MonoBehaviour
{
    public int skaits = 0;
    public GameObject bilde;
    public GameObject restart;

    // Update is called once per frame
    void Update()
    {
        if(skaits==11)
        {
            bilde.SetActive(true);
            restart.SetActive(true);
        } else
        {
            bilde.SetActive(false);
            restart.SetActive(false);
        }
    }

    public void skaitijas()
    {
        skaits++;
    }
}
