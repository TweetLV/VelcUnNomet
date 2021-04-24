using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacijas : MonoBehaviour
{
    //Uzglabā noradi uz Objektu skriptu
    public Objekti objektuSkripts;

    void Update()
    {
       //Ja ir kāds pēdejais vilktais objekts, tad var veikt darbības ar to
       if(objektuSkripts.pedejaisVilktais != null)
        {
            //nospiežot pogu Z var rotet pa pulksteņrādītāja virzienu
            if (Input.GetKey(KeyCode.Z))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 9f);
            }
            //nospiežot pogu X var rotet pretēji pulksteņrādītāja virzienam
            if (Input.GetKey(KeyCode.X))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 9f);
            }


            //Nospiežot bultiņu pa kreisi, iespējams objektu stiept šaurāku pa x asi
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //Lai objektu nevar izstiept mīnusā
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x > 0.35)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x - 0.001f, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);
                }
            }
            //Nospiežot bultiņu pa labi, iespējams objektu stiept lielāku pa x asi
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //Lai objektu nevar izstiept parak plašu
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x < 0.9)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.001f, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);
                }
            }
            //Nospiežot bultiņu uz augšu, iespējams objektu stiept lielāku pa y asi
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Lai objektu nevar izstiept parak plašu
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y < 0.8)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y + 0.001f);
                }
            }
            //Nospiežot bultiņu uz leju, iespējams objektu stiept šaurāku pa y asi
            if (Input.GetKey(KeyCode.DownArrow))
            {
                //Lai objektu nevar izstiept mīnusā
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y > 0.35)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y - 0.001f);
                }
            }
        }
        }
    }

