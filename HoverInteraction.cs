using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HoverInteraction : MonoBehaviour {
    public Text ChildText;
    public Image FillImage;
    public Button Btn;

    private Color initTextColor;
    private ButtonInteractionGroup parent;
    HoverInteraction self;
    private void Awake()
    {
        self = this.GetComponent<HoverInteraction>();
        if(this.GetComponent<Button>()!=null)
        setButton(this.GetComponent<Button>());
    }

    public Button getButton(){return this.Btn; }
    public void setButton(Button b){ this.Btn = b; }
    public void SetActive(bool b){
        if(Btn!=null) Btn.interactable=b;
        if(ChildText!=null) ChildText.enabled =(b);

    }
    private void Start()
    {
        self = this.GetComponent<HoverInteraction>();
        ChildText = GetComponentInChildren<Text>();
        initTextColor = ChildText.color;
        parent = GetComponentInParent<ButtonInteractionGroup>();
    }
    public void OnHoverStart()
    {
        ChildText.color = Color.white;
        Color c = FillImage.color;
        c.a = 1;
        FillImage.color = c;
    }
    public void OnHoverEnd()
    {
        ChildText.color = initTextColor;
        Color c = FillImage.color;
        c.a = 0;
        FillImage.color = c;
    }
    public void OnSelected()
    {
        parent.HighlightButton(self);
    }
    public void Highlight()
    {
        ChildText.color = Color.white;
        Color c = FillImage.color;
        c.a = 1;
        FillImage.color = c;
    }
    public void Unhighlight()
    {
        ChildText.color = initTextColor;
        Color c = FillImage.color;
        c.a = 0;
        FillImage.color = c;
    }
}
