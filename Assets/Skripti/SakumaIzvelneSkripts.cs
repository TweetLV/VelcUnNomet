using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Pievieno SceneManagement komponenti
using UnityEngine.SceneManagement;

public class SakumaIzvelneSkripts : MonoBehaviour
{
    //Pārceļ ainu uz Sākuma ekrānu
    public void ParceltAinu()
    {
        SceneManager.LoadScene("PilsetasAina");
    }
    //Pārceļ ainu uz spēli
    public void UzSakumaIzvelni()
    {
        SceneManager.LoadScene("SakumaIzvelne");
    }
}
