using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class OnMouseDownScript : MonoBehaviour {
    public GameObject[] ObjsToHigh;
    bool Highlighted = false;
    private void Update()
    {



        if (ObjsToHigh.Length <= 0) return;
        foreach (GameObject obj in ObjsToHigh)
        {
            foreach (Material m in obj.GetComponent<MeshRenderer>().materials)
            {
                //float value = m.GetFloat("_HighlightAmount");
                //if(Highlighted)
                //    value = Mathf.Lerp(value, .75f, Time.fixedDeltaTime);
                //else
                //    value = Mathf.Lerp(value, 0, Time.fixedDeltaTime);
                //m.SetFloat("_HighlightAmount", value);
            }
        }
    }
    void OnMouseDown()
    {
       // Debug.Log("Mouse down");
        EventTrigger trigger = GetComponent<EventTrigger>();
        PointerEventData data = new PointerEventData(EventSystem.current);
        trigger.OnPointerClick(data );
    }
    void OnMouseEnter()
    {
        Highlighted = true;
    }
    void OnMouseExit()
    {
        Highlighted = false;

    }



}
