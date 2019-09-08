using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour {
    public static AnimatorController instance;
    public Animator MainAnim,BatteryAnim;
    public bool BackOpen = false, FrontOpen = false, TrunkOpen = false, BatteryOpen = false;
    public BoxCollider BatteryCollider;
    private Vector3 initBatColSize;
    private float AnimDelay = 3f;
    private float LastAnimcall = 0;
    // Use this for initialization
    public Transform BatteryContainer;
    private void Awake()
    {
        instance = this.GetComponent<AnimatorController>();
    }
    void Start () {
        //anim = GetComponent<Animator>();
        initBatColSize = BatteryCollider.size;
        
    }
	void Update(){
        //if (BatteryOpen)   BatteryContainer.localPosition = Vector3.Lerp(BatteryContainer.localPosition, new Vector3(0,1,0), Time.fixedDeltaTime);
        //else   BatteryContainer.localPosition = Vector3.Slerp(BatteryContainer.localPosition, new Vector3(0,0,0), Time.fixedDeltaTime);

	}
    public void OpenBattery()
    {
        if (Time.time - LastAnimcall < AnimDelay)
            return;
        LastAnimcall = Time.time;
        Debug.Log("Open battery");
        if (BatteryOpen)
        {
            // BatteryAnim.Play("ReverseExplode");
            // BatteryOpen = false;
            // BatteryCollider.size = initBatColSize;
            StartCoroutine( "StartCloseBat");
        }
        else
        {
            StartCoroutine( "StartOpenBat");
       // BatteryContainer.localPosition = new Vector3(0,1,0);
            
        }
    }

    IEnumerator StartOpenBat(){
        float x = BatteryContainer.localPosition.y;
        while(x<1){
            BatteryContainer.localPosition += new Vector3(0,1,0) *Time.fixedDeltaTime *2f;
            x = BatteryContainer.localPosition.y;
            yield return new WaitForSeconds(.01f);
        }
        BatteryContainer.localPosition = new Vector3(0,1,0);
        BatteryAnim.Play("Explode");
        BatteryOpen = true;
        BatteryCollider.size = new Vector3(initBatColSize.x, initBatColSize.y*4f, initBatColSize.z); 
        Debug.Log("Battery open");
    }
    IEnumerator StartCloseBat(){

        bool Animate =true;
        while(Animate){
            BatteryAnim.Play("ReverseExplode");
            BatteryOpen = false;
            BatteryCollider.size = initBatColSize;
            Animate = false;
            yield return new WaitForSeconds(1f);
        }


        float x = BatteryContainer.localPosition.y;
        while(x>0){
            BatteryContainer.localPosition -= new Vector3(0,1,0) *Time.fixedDeltaTime *2f;
            x = BatteryContainer.localPosition.y;
            yield return new WaitForSeconds(.01f);
        }
        BatteryContainer.localPosition = new Vector3(0,0,0);
    }





    public void CloseAll()
    {
        if (BatteryOpen)
        {
             StartCoroutine( "StartCloseBat");
        }
        if (TrunkOpen)
        {
            MainAnim.Play("TrunkClose");
            TrunkOpen = false;
        }
        if (FrontOpen)
        {
            MainAnim.Play("FrontDoorsClose");
            FrontOpen = false;
        }
        if (BackOpen)
        {
            MainAnim.Play("BackDoorsClose");
            BackOpen = false;
        }
    }
    public void SetBattery(bool v)
    {
        if (BatteryOpen && !v)
        {
             StartCoroutine( "StartCloseBat");
        }
        else if(!BatteryOpen && v)
        {
             StartCoroutine( "StartOpenBat");
        }
    }
    public void OpenTrunk()
    {
        if (Time.time - LastAnimcall < AnimDelay)
            return;
        LastAnimcall = Time.time;
        
        if (BackOpen)
        {
            MainAnim.Play("BackDoorsCloseThenTrunkOpen");
            BackOpen = false;
            TrunkOpen = true;
        }
        else if (FrontOpen)
        {
            MainAnim.Play("FrontDoorsCloseThenTrunkOpen");
            FrontOpen = false;
            TrunkOpen = true;
        }
        else if (TrunkOpen)
        {
            MainAnim.Play("TrunkClose");
            TrunkOpen = false;
        }
        else if(!TrunkOpen)
        {
            MainAnim.Play("TrunkOpen");
            TrunkOpen = true;
        }
    }
    public void OpenFrontDoor()
    {
        if (Time.time - LastAnimcall < AnimDelay)
            return;
        LastAnimcall = Time.time;

        if (BackOpen)
        {
            MainAnim.Play("BackDoorsCloseThenFrontOpen");
            BackOpen = false;
            FrontOpen = true;
        }
        else if (TrunkOpen)
        {
            MainAnim.Play("TrunkCloseThenFrontOpen");
            TrunkOpen = false;
            FrontOpen = true;
        }
        else if (FrontOpen)
        {
            MainAnim.Play("FrontDoorsClose");
            FrontOpen = false;
        }
        else if(!FrontOpen)
        {
            MainAnim.Play("FrontDoorsOpen");
            FrontOpen = true;
        }
    }
    public void OpenBackDoor()
    {
        if (Time.time - LastAnimcall < AnimDelay)
            return;
        LastAnimcall = Time.time;
        if (FrontOpen)
        {
            MainAnim.Play("FrontDoorsCloseThenBackOpen");
            FrontOpen = false;
            BackOpen = true;

        }
        else if (TrunkOpen)
        {
            MainAnim.Play("TrunkCloseThenBackOpen");
            TrunkOpen = false;
            BackOpen = true;

        }
        else if (BackOpen)
        {
            MainAnim.Play("BackDoorsClose");
            BackOpen = false;
        }
        else if(!BackOpen)
        {
            MainAnim.Play("BackDoorsOpen");
            BackOpen = true;

        }
    }

}
