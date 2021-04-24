using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai lietotu pointer darbību interfeisu
//Papildus ir jāpārliecinās, ka projektā pie Canvas ir importēta EventSystem UI komponente.
using UnityEngine.EventSystems;

//Piesaista pointer interfeisu
public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Objekti objektuSkripts;
    public SpelesBeigas SpelesBeigas;
    private RectTransform velkObjRectTransf;
    private CanvasGroup kanvasGrupa;

    private void Awake()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }
    //Funkcija nostrādā, kad uzkliksķināts uz parvietojama objekta
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Kreisais klikšķis uz parvietojamā objekta!");
    }
    //Funckija nostrādā uzsākot pārvietošanu
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsakta parvietošana!");
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    //Funkcija nostrādā pārvietošanas brīdī
    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek vilkšana!");
        velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
    {
        objektuSkripts.pedejaisVilktais = notikums.pointerDrag;
        Debug.Log("Pedejais vilktais objekts: " + objektuSkripts.pedejaisVilktais);
        Debug.Log("Vilkšana pabeigta!");
        kanvasGrupa.alpha = 1f;

        if (objektuSkripts.vaiIstajaVieta==false)
        {
            kanvasGrupa.blocksRaycasts = true;

        }
        else
        //Tiek izsaukta spēles beigas metode, lai saskaitītu novietotās mašīnas.
        {
            objektuSkripts.pedejaisVilktais = null;
            SpelesBeigas.skaitijas();
        }

        objektuSkripts.vaiIstajaVieta = false;
    }

}
