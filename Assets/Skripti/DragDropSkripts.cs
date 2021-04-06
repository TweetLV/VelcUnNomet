using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importē, lai lietotu pointer darbību interfeisu
//Papildus ir jāpārliecinās, ka projektā pie Canvas ir importēta EventSystem UI komponente.
using UnityEngine.EventSystems;

//Piesaista pointer interfeisu
public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
   // public Objekti objektuSkripts;
    private RectTransform transformacijuLogs;
    private CanvasGroup kanvasGrupa;

    private void Awake()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        transformacijuLogs = GetComponent<RectTransform>();
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
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    //Funkcija nostrādā pārvietošanas brīdī
    public void OnDrag(PointerEventData notikums)
    {
        //transformacijuLogs.anchoredPosition += notikums.delta / objektuSkripts.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Vilkšana pabeigta!");
    }

}
