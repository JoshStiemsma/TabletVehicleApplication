using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class MainCanvas : MonoBehaviour {
   public int CurrentCategory = 0, CurrentSubCategory = 0;
   // public int OnData = 0;
    public GameObject TextboxPrefab;
    public RectTransform rectT;
    private TextData data;
    public TextBox tb;
    public List<string> currentData = new List<string>();
    public string currentTitle = "", currentSubTitle = "";

    BaseController baseCont;

    private Vector2 MouseDragStart = Vector2.zero;
    private Vector3 init = Vector3.zero;



    public Text CategoryTitle_Text,Challenge_Text, Solution_Text, Products_Text;
    public Image  Challenge_FillImg, Solution_FillImg, Products_FillImg;
    public GameObject SubCategoryPanel;
    public CanvasGroup SubCatGroup;

    private bool SubOpen=false;
    private Vector3 subInitPos;
    public FadeController FC;
    public HighlightController HC;
    public ButtonInteractionGroup SubBtns;
    private Vector3 initDuraPos;


    private void Start()
    {
        HC = HighlightController.instance;
        baseCont = BaseController.instance;
        FC = FadeController.self;
        GrabData(false);
        HideData();
        initDuraPos =SubBtns.btns[4].transform.localPosition; 
        subInitPos = SubCategoryPanel.transform.position;
    }
    void Update(){
        // if(SubOpen)  SubCategoryPanel.transform.position = Vector3.Lerp(SubCategoryPanel.transform.position, subInitPos, Time.fixedDeltaTime*15f);
        // else SubCategoryPanel.transform.position = Vector3.Lerp(SubCategoryPanel.transform.position, subInitPos - (Vector3.right * 4000f), Time.fixedDeltaTime*15f);
       


       if(SubOpen && SubCatGroup.alpha<1){
            SubCatGroup.alpha+=Time.fixedDeltaTime*5f;
            SubCatGroup.interactable =true;
            SubCatGroup.blocksRaycasts =true;

        }else if(!SubOpen && SubCatGroup.alpha>0){ 
            SubCatGroup.alpha-=Time.fixedDeltaTime*5f;
            SubCatGroup.interactable =false;
            SubCatGroup.blocksRaycasts =false;
         }
    }
    public GameObject PressAudioPrefab,ChangeAudioPrefab;
    void PlayDing(){
        Destroy(Instantiate(PressAudioPrefab, Vector3.zero, Quaternion.identity), 4);
    }
    void PlayChange(){
        Destroy(Instantiate(ChangeAudioPrefab, Vector3.zero, Quaternion.identity), 4);
    }
    public void SelectCategory(int i)
    {
        CurrentCategory = i;

        //PLAY DING
        PlayDing();
        if (i != 0)
        {
            GrabData(true);
            CategoryTitle_Text.GetComponent<textGarble>().GarbleIn(currentTitle);
            SubOpen=true;
        }
        else {
            CategoryTitle_Text.GetComponent<textGarble>().GarbleIn("Exterior");
            SubOpen=false;
        }
        if(i==4)
        	ToggleDurabButton(false);
        else
        	ToggleDurabButton(true);
        CurrentSubCategory =-1;
        FC.UpdateLayer(i);
        //HC.RemoveHighlight();
        HC.UpdateData(CurrentCategory, CurrentSubCategory);

        HideData();
        SubBtns.UnHighlight();
    }
    void ToggleDurabButton(bool b){
    	// if(!b)
    	// 	SubBtns.btns[4].transform.localPosition = SubBtns.btns[3].transform.localPosition;
    	// else
    	// 	SubBtns.btns[4].transform.localPosition = initDuraPos;
    	SubBtns.btns[3].SetActive(b);
    }
    public void SelectSubCategory(int i)
    {
        PlayDing();
        PlayChange();
        CurrentSubCategory = i;
        GrabData(true);
        HC.UpdateData(CurrentCategory, CurrentSubCategory);

    }
    bool currentlyUpdateingData = false;
    void UpdateData()
    {
        if (currentlyUpdateingData)
            StopAllCoroutines();
        StartCoroutine("StartUpdateData");
    }
    void HideData(){
        if (currentlyUpdateingData)
            StopAllCoroutines();
        StartCoroutine(FadeThisImg(Challenge_FillImg, Challenge_Text, ""));
        StartCoroutine(FadeThisImg(Solution_FillImg, Solution_Text, ""));
        StartCoroutine(FadeThisImg(Products_FillImg, Products_Text, ""));
    }
    IEnumerator StartUpdateData()
    {
        currentlyUpdateingData = true;
        int count = 0;
        while (count < 3)
        {
            if (count == 0)
            {
                StartCoroutine(FadeThisImg(Challenge_FillImg, Challenge_Text, currentData[0]));
                count++;
                yield return new WaitForSeconds(.05f);
            }
            else if (count == 1)
            {
                StartCoroutine(FadeThisImg(Solution_FillImg, Solution_Text, currentData[1]));
                count++;
                yield return new WaitForSeconds(.05f);
            }
            else if (count == 2)
            {
                StartCoroutine(FadeThisImg(Products_FillImg, Products_Text, currentData[2]));
                count++;
                yield return new WaitForSeconds(.05f);
            }
        }

        yield return new WaitForSeconds(1f);
        currentlyUpdateingData = false;
    }
    private float ColorFadeSpeed = 3f;
    IEnumerator FadeThisImg(Image img,Text text, string data)
    {
        if (data != null && data.Length >3)
        {
            //set alpha full
            Color clr = img.color;
            float alpha = 1f;

            clr.a = alpha;
            img.transform.parent.localScale = Vector3.one;

            text.GetComponent<textGarble>().GarbleIn(data);

            while (alpha > 0)
            {
                alpha -= Time.fixedDeltaTime * ColorFadeSpeed;
                clr.a = alpha;
                img.color = clr;
                yield return new WaitForSeconds(.01f);
            }
        }
        else
        {
            img.transform.parent.localScale = Vector3.zero;
        }
     
    }

    void GrabTitle()
    {
        if (CurrentCategory == 1) currentTitle = "Vehicle Structure";
        else if (CurrentCategory == 2) currentTitle = "Battery Pack";
        else if (CurrentCategory == 3) currentTitle = "Electric Motor";
        else if (CurrentCategory == 4) currentTitle = "Chasis & Powertrain";
        else if (CurrentCategory == 0) currentTitle = "Exterior";


        if (CurrentSubCategory == 0) currentSubTitle = "LightWeighting";
        else if (CurrentSubCategory == 1) currentSubTitle = "Safety";
        else if (CurrentSubCategory == 2) currentSubTitle = "NVH";
        else if (CurrentSubCategory == 3) currentSubTitle = "Durability";
        else if (CurrentSubCategory == 4) currentSubTitle = "Sensing";
    }
    void GrabData(bool update)
    {
        GrabTitle();
        if(CurrentCategory == 0)
        {
            currentData = new List<string>{"","",""};
        }
        else  if(CurrentCategory == 1)
        {
            if(CurrentSubCategory == 0)currentData = TextData.vehiclestructure.lightweighting.data;          
            else if (CurrentSubCategory == 1) currentData = TextData.vehiclestructure.safety.data;           
            else if (CurrentSubCategory == 2) currentData = TextData.vehiclestructure.nvh.data;           
            else if (CurrentSubCategory == 3) currentData = TextData.vehiclestructure.durability.data;            
            else if (CurrentSubCategory == 4) currentData = TextData.vehiclestructure.sensing.data;
            else if(CurrentSubCategory == -1) currentData = TextData.vehiclestructure.lightweighting.data;     
        }
        else if (CurrentCategory == 2)
        {
           if (CurrentSubCategory == 0) currentData = TextData.batterypack.lightweighting.data;
            else if (CurrentSubCategory == 1) currentData = TextData.batterypack.safety.data;
            else if (CurrentSubCategory == 2) currentData = TextData.batterypack.nvh.data;
            else if (CurrentSubCategory == 3) currentData = TextData.batterypack.durability.data;
            else if (CurrentSubCategory == 4) currentData = TextData.batterypack.sensing.data;
            else if(CurrentSubCategory == -1) currentData = TextData.vehiclestructure.lightweighting.data;   
        }
        else if (CurrentCategory == 3)
        {
            if (CurrentSubCategory == 0) currentData = TextData.electricMotors.lightweighting.data;
            else if (CurrentSubCategory == 1) currentData = TextData.electricMotors.safety.data;
            else if (CurrentSubCategory == 2) currentData = TextData.electricMotors.nvh.data;
            else if (CurrentSubCategory == 3) currentData = TextData.electricMotors.durability.data;
            else if (CurrentSubCategory == 4) currentData = TextData.electricMotors.sensing.data;
            else if(CurrentSubCategory == -1) currentData = TextData.vehiclestructure.lightweighting.data;   
        }
        else if (CurrentCategory == 4)
        {
            if (CurrentSubCategory == 0) currentData = TextData.chasis.lightweighting.data;
            else if (CurrentSubCategory == 1) currentData = TextData.chasis.safety.data;
            else if (CurrentSubCategory == 2) currentData = TextData.chasis.nvh.data;
            else if (CurrentSubCategory == 3) currentData = TextData.chasis.durability.data;
            else if (CurrentSubCategory == 4) currentData = TextData.chasis.sensing.data;
            else if(CurrentSubCategory == -1) currentData = TextData.vehiclestructure.lightweighting.data;   
        }
        if(update)
        UpdateData();
    }


    //Movement Drag
    public void StartDrag()
    {
        baseCont.canSpin = false;
        MouseDragStart = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        init = rectT.localPosition;
    }
    public void UpdateDrag()
    {
        Vector2 offset = new Vector2(Input.mousePosition.x - MouseDragStart.x, Input.mousePosition.y - MouseDragStart.y);
        rectT.localPosition = init + new Vector3(offset.x, offset.y, 0);
        //Debug.Log(rect.localPosition);
    }
    public void EndDrag()
    {
        baseCont.canSpin = true;
       // baseCont.spinVelocity = 0f;
        baseCont.StopNextMotion = true;
    }

    //Resize Drag
    public void StartScaleDrag()
    {
        baseCont.canSpin = false;
        MouseDragStart = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

    }
    public void UpdateScaleDrag()
    {
        Vector2 size = rectT.rect.size;
        Vector3 pos = rectT.localPosition;



        Vector2 offset = new Vector2(Input.mousePosition.x - MouseDragStart.x, Input.mousePosition.y - MouseDragStart.y);
        offset.y *= -1f;

        if (size.x < 400 && offset.x > 0 || size.x > 100 && offset.x < 0)
            pos = pos + new Vector3(offset.x, 0, 0) / 2f;
        if (size.y < 400 && offset.y > 0 || size.y > 100 && offset.y < 0)
            pos = pos + new Vector3(0, -offset.y, 0) / 2f;

        size = size + new Vector2(offset.x, 0);
        size = size + new Vector2(0, offset.y);

        size.x = Mathf.Clamp(size.x, 100, 400);
        size.y = Mathf.Clamp(size.y, 100, 400);

        rectT.sizeDelta = size;
        rectT.localPosition = pos;

        MouseDragStart = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

    }
    public void EndScaleDrag()
    {
        baseCont.canSpin = true;
    }


    
}

