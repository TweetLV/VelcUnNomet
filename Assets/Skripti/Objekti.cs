using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //GameObject, kas uzglabā velkamos objektus
    public GameObject atkritumuMasina;
    public GameObject autobuss;
    public GameObject atroMasina;
    public GameObject b2;
    public GameObject e46;
    public GameObject ekskavators;
    public GameObject cementaMasina;
    public GameObject policja;
    public GameObject traktors1;
    public GameObject traktors5;
    public GameObject ugunsdzeseji;


    //Uzglabās velkamo objektu sākotnējās pozīcijas koordinatas(lai zinātu, kur aizmest objektu, ja tas nolikts nepareizaja vietā)
    //Objekti paliek Public, taču paslēpj no Inspector loga
    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 busKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 ekskavatorsKoord;
    [HideInInspector]
    public Vector2 cementKoord;
    [HideInInspector]
    public Vector2 policijaKoord;
    [HideInInspector]
    public Vector2 trak1Koord;
    [HideInInspector]
    public Vector2 trak5Koord;
    [HideInInspector]
    public Vector2 ugunsKoord;
    //Uzglabās ainā esošo kanvu
    public Canvas kanva;
    //Uzglabās ainā esošo kanvu
    public AudioSource skanasAvots;
    //Masīvs kas uzglabās visas skaņas
    public AudioClip[] skanaKoAtskanot;
    //Uzglabās objektu, kurš ir pēdējais pārvietotais
    [HideInInspector]
    public GameObject pedejaisVilktais=null;
    //Mainigais atbild vai objekts ir nolikt pareizi vai nepareizi
    [HideInInspector]
    public bool vaiIstajaVieta = false;

    //Funkcija nostrādā tiklīdz nospiesta play poga
    private void Awake()
    {
        atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
        atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        busKoord = autobuss.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        ekskavatorsKoord = ekskavators.GetComponent<RectTransform>().localPosition;
        cementKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
        policijaKoord = policja.GetComponent<RectTransform>().localPosition;
        trak1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        trak5Koord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
    }

}
