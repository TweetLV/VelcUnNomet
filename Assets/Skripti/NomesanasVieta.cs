using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jaīmportē, lai varētu piesaistīt IDropHandler interfeisu un lietot OnDrop funkciju
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler{
    //https://prnt.sc/11aiwm8
    private float vietasZrot, velkamaObjeZrot, rotacijasStarpiba;
    //Uzglabās objekta un nomešanas vietas izmērus
    private Vector2 vietasIzm, velkObjIzm;
    //Uzglabās objektu x un y ass izmēru starpību
    private float xIzmeruStarpiba, yIzmeruStarpiba;
    //Nordāda uz skriptu objekti
    public Objekti objektuSkripts;

    //Nostrādā, ja objektu cenšas nomest uz nometamā lauka
    public void OnDrop(PointerEventData notikums)
    {
        //Parbaudīs vai kāds objekts tiek vilkts un nomests
        if(notikums.pointerDrag != null)
        {
            //Ja nomešanas laukā uzmestā attēla tags sakrī ar lauka tagu
            if ((notikums.pointerDrag.tag.Equals(tag)))
            {
                //Iegūst rotāciju grādos
                vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                velkamaObjeZrot = GetComponent<RectTransform>().transform.eulerAngles.z;
                //Apreiķina rotāciju starpību
                rotacijasStarpiba = Mathf.Abs(vietasZrot - velkamaObjeZrot);
                //Iegūst objektu izmērus
                vietasIzm = notikums.pointerDrag.GetComponent<RectTransform>().localScale;
                velkObjIzm = GetComponent<RectTransform>().localScale;
                xIzmeruStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
                yIzmeruStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

                //Pārbauda vai objektu savstarpējā rotācija neatškirās vairāk par 9 grādiem un vai x un y izmeri neatšķirās vairāk par 0.15
                if ((rotacijasStarpiba <= 9 || (rotacijasStarpiba >= 351 & rotacijasStarpiba <= 360)) && (xIzmeruStarpiba <= 0.15 && yIzmeruStarpiba <= 0.15))
                {
                    objektuSkripts.vaiIstajaVieta = true;
                    //Nometamo objektu iecentrē nomešanas vietā
                    notikums.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    //Pielāgo nomestā objekta izmēru
                    notikums.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation ;
                    //Pielāgo nomestā objekta izmēru
                    notikums.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;




                    //Pārbauda pēc tagiem, kurš no objektiem ir pareizi nomests, tad atskaņo atbilstošo skaņu
                    switch (notikums.pointerDrag.tag)
                    {
                        case "Atkritumi":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[1]);
                        break;
                        case "Skola":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
                        break;
                        case "Atrie":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
                        break;
                        case "Policija":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[4]);
                            break;
                        case "Ugunsdzeseji":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[5]);
                            break;
                        case "e46":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[6]);
                            break;
                        case "b2":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[7]);
                            break;
                        case "cements":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[8]);
                            break;
                        case "Traktors1":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[9]);
                            break;
                        case "Traktors5":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[10]);
                            break;
                        case "Ekskavators":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[11]);
                            break;

                        default:
                            Debug.Log("Nedefinēts tags!");
                            break;
                    }
                }
                //Ja objektu tagi nesakrī un nomet nepareizajā vietā
            }else{
                objektuSkripts.vaiIstajaVieta = false;
                //Atskaņo skaņu
                objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0]);
                //Atkarībā no objektu taga, kuŗš tika vilkts, objektu uzbīda uz tā sākotnējām koordinātām
                switch (notikums.pointerDrag.tag)
                {
                    case "Atkritumi":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrKoord;
                        break;
                    case "Skola":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.busKoord;
                        break;
                    case "Atrie":
                        objektuSkripts.atroMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atroKoord;
                        break;
                    case "e46":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;
                    case "b2":
                        objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;
                    case "cements":
                        objektuSkripts.cementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.cementKoord;
                        break;
                    case "Policja":
                        objektuSkripts.policja.GetComponent<RectTransform>().localPosition = objektuSkripts.policijaKoord;
                        break;
                    case "Ugunsdzeseji":
                        objektuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsKoord;
                        break;
                    case "Traktors1":
                        objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.trak1Koord;
                        break;
                    case "Traktors5":
                        objektuSkripts.traktors5.GetComponent<RectTransform>().localPosition = objektuSkripts.trak5Koord;
                        break;
                    case "Ekskavators":
                        objektuSkripts.ekskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.ekskavatorsKoord;
                        break;

                    default:
                        Debug.Log("Objektam nav noteikta parvietošanas vieta!");
                        break;
                }

            }
        }
    }
}