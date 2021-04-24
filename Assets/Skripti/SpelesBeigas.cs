using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelesBeigas : MonoBehaviour
{
    public int skaits = 0;
    public GameObject bilde;
    public GameObject restart;
    public GameObject back;

   //Ja skaits ir 11, tiek parādīts uzvaras ekrāns ar visām funkcijām.
    void Update()
    {
        if(skaits==11)
        {
            back.SetActive(true);
            bilde.SetActive(true);
            restart.SetActive(true);
        } else
        {
            back.SetActive(false);
            bilde.SetActive(false);
            restart.SetActive(false);
        }
    }
    //Skaitītājs, kurš skaita pareizi novietotās mašīnas.
    public void skaitijas()
    {
        skaits++;
    }
}
