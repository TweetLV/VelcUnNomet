using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //GameObject, kas uzglabā velkamos objektus
    public GameObject atkritumuMasina;
    public GameObject autobuss;
    public GameObject atroMasina;

    //Uzglabās velkamo objektu sākotnējās pozīcijas koordinatas(lai zinātu, kur aizmest objektu, ja tas nolikts nepareizaja vietā)
    //Objekti paliek Public, taču paslēpj no Inspector loga
    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 busKoord;
    //Uzglabās ainā esošo kanvu
    public Canvas kanva;
    //Uzglabās ainā esošo kanvu
    public AudioSource skanasAvots;
    //Masīvs kas uzglabās visas skaņas
    public AudioClip[] skanaKoAtskanot;
    //Uzglabās objektu, kurš ir pēdējais pārvietotais
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
    }

}
