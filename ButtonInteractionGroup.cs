using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractionGroup : MonoBehaviour {
    public GameObject parent;
    public List<HoverInteraction> btns = new List<HoverInteraction>();
	// Use this for initialization
	void Start () {
        foreach (HoverInteraction h in parent.GetComponentsInChildren<HoverInteraction>())
            btns.Add(h);
	}
	
	public void HighlightButton(HoverInteraction h)
    {
        foreach (HoverInteraction _h in btns)
        {
           // if (h != _h)
                _h.Unhighlight();
        }
        h.Highlight();
    }
    public void UnHighlight(){
        foreach (HoverInteraction _h in btns)
        {
           _h.Unhighlight();
        }
    }
}
