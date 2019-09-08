using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class HighlightGroup
{
    public string name;
    public List<GameObject> objsAndChildren = new List<GameObject>();
    public List<GameObject> objsNoChildren = new List<GameObject>();
    public List<SpecificMaterialIndexItem> CustomMatItems = new List<SpecificMaterialIndexItem>();
}
[System.Serializable]
public class SpecificMaterialIndexItem
{
    public GameObject Obj;
    public List<int> Index = new List<int>(1);
}



[System.Serializable]
public class HighlightGroup_Group
{
    public List<HighlightGroup> groups = new List<HighlightGroup>(5);
}
public class HighlightController : MonoBehaviour {
    public static HighlightController instance;
    private float SpeedScale = 1f;

    public HighlightGroup_Group Exterior;
    //public HighlightGroup_Group Structure;
    public HighlightGroup_Group Battery;
    public HighlightGroup_Group Motor;
    public HighlightGroup_Group Chassis;


    public HighlightGroup CurrentlyHighlightedObjs;
    public List<HighlightGroup> ObjectToUnhighlight = new List<HighlightGroup>();


    public GameObject SensorsTop,SensorsBottom;
    private void Awake()
    {
        instance = this.GetComponent<HighlightController>();
    }
    void Update(){
        if(ObjectToUnhighlight.Count >0){
            foreach(HighlightGroup g in ObjectToUnhighlight)
                StartCoroutine(StartReturnHighlightObjs(g));
                ObjectToUnhighlight.Clear();
        }
        
    }
    void SetSensors(GameObject obj, bool b){
        obj.SetActive(b);
    }
    public void RemoveHighlight(){
        //StopAllCoroutines();
        SetSensors(SensorsTop,false);
        SetSensors(SensorsBottom,false);

        if(CurrentlyHighlightedObjs!=null){
            SetActiveFlags(CurrentlyHighlightedObjs,0);
             ObjectToUnhighlight.Add(CurrentlyHighlightedObjs);
            //StartCoroutine(StartReturnHighlightObjs(CurrentlyHighlightedObjs));
        }
    }

    public void UpdateData(int cat, int subCat)
    { 
        
        HighlightGroup prevGroup=null;
        StopAllCoroutines();

        if(CurrentlyHighlightedObjs!=null){
            prevGroup = CurrentlyHighlightedObjs;
            //StartCoroutine(StartReturnHighlightObjs(prevGroup));
            //StopCoroutine(StartHighlightObjs(prevGroup));
            SetActiveFlags(prevGroup,0);
            ObjectToUnhighlight.Add(prevGroup);
        }



        HighlightGroup_Group group = Exterior;
        CurrentlyHighlightedObjs=null;
        
       if (cat == 1)
            group = Exterior;
        else if (cat == 2)
            group = Battery;
        else if (cat == 3)
            group = Motor;
        else if (cat == 4)
            group = Chassis;

            //when on one only have bottoms
        if(cat ==1 && (subCat == 1 || subCat == 4)){
            SetSensors(SensorsBottom, true);
        }
        else {
            SetSensors(SensorsBottom,false);
        }


        if(cat ==1 && subCat == 4){
            SetSensors(SensorsTop,true);
        }
        else {
            SetSensors(SensorsTop,false);
        }

        if (cat != 0 && group.groups.Count >= subCat && subCat!=-1)
        {
            CurrentlyHighlightedObjs = group.groups[subCat];
            SetActiveFlags(CurrentlyHighlightedObjs,1);
            //tag mats that will be used in next highlight
            // unhighlight(knowng which ones not to do cause theyre marke as active within shader)
           // if(prevGroup != null)
                //StartCoroutine(StartReturnHighlightObjs(prevGroup));

            StartCoroutine(StartHighlightObjs(CurrentlyHighlightedObjs));
        }else{
            if(prevGroup != null)
            SetActiveFlags(prevGroup,0);
            //if(prevGroup != null)
                //StartCoroutine(StartReturnHighlightObjs(prevGroup));
        }
    }



    void SetActiveFlags(HighlightGroup g,float active){
       // Debug.Log("set active " + active);
        HandleChildrenFlags(g,active);
        HandleNoChildrenFlags(g,active);
        HandleSpecialFlags(g,active);
    }
    IEnumerator StartHighlightObjs(HighlightGroup g)
    {
        float val = 0;
        while(val < 1)
        {
            HandleChildrenGroup(g,val,true);
            HandleNoChildrenGroup(g,val,true);
            HandleSpecialGroup(g,val,true);
            val += Time.fixedDeltaTime*SpeedScale;
            yield return new WaitForSeconds(.01f);
        }

        HandleChildrenGroup(g,1,true);
        HandleNoChildrenGroup(g,1,true);
        HandleSpecialGroup(g,1,true);


        //SetActiveFlags(g,0);
    }


   
    void HandleChildrenFlags(HighlightGroup g, float active){
        foreach (GameObject obj in g.objsAndChildren)
            {
                if (obj !=null){
                    if (obj.GetComponent<MeshRenderer>() != null)
                        SetActiveFlagOnMesh( obj.GetComponent<MeshRenderer>(), active);
                    foreach (MeshRenderer m in obj.GetComponentsInChildren<MeshRenderer>())
                        SetActiveFlagOnMesh( m, active);
                }
        }
    }
    void HandleNoChildrenFlags(HighlightGroup g, float active){
         foreach (GameObject obj in g.objsNoChildren)
            {
                if (obj !=null && obj.GetComponent<MeshRenderer>() != null)
                        SetActiveFlagOnMesh( obj.GetComponent<MeshRenderer>(), active);
            }
    }
    void HandleSpecialFlags(HighlightGroup g, float active){
         foreach (SpecificMaterialIndexItem s in g.CustomMatItems){
                if (s.Obj.GetComponent<MeshRenderer>() != null){
                    foreach(int i in s.Index)
                    SetActiveFlagOnMaterial(s.Obj.GetComponent<MeshRenderer>().materials[i], active);
                }
            }
    }


    void HandleChildrenGroup(HighlightGroup g, float val, bool up){
        foreach (GameObject obj in g.objsAndChildren)
        {
            if (obj !=null){
                if (obj.GetComponent<MeshRenderer>() != null)
                    SetHighlightOnMesh(val, obj.GetComponent<MeshRenderer>(), up);
                foreach (MeshRenderer m in obj.GetComponentsInChildren<MeshRenderer>())
                    SetHighlightOnMesh(val, m, up);
            }
        }
    }
    void HandleNoChildrenGroup(HighlightGroup g, float val, bool up){
         foreach (GameObject obj in g.objsNoChildren)
            {
                if (obj !=null && obj.GetComponent<MeshRenderer>() != null)
                        SetHighlightOnMesh(val, obj.GetComponent<MeshRenderer>(), up);
            }
    }
    void HandleSpecialGroup(HighlightGroup g, float val, bool up){
         foreach (SpecificMaterialIndexItem s in g.CustomMatItems){
                if (s.Obj.GetComponent<MeshRenderer>() != null){
                    foreach(int i in s.Index)
                    SetHighlightOnMaterial(val, s.Obj.GetComponent<MeshRenderer>().materials[i], up);
                }
            }
    }

    IEnumerator StartReturnHighlightObjs(HighlightGroup g)
    {
        if(g!=null){
            Debug.Log("Return highlights");
            float val = 1;
            while (val >0)
            {
                HandleChildrenGroup(g,val,false);
                HandleNoChildrenGroup(g,val,false);
                HandleSpecialGroup(g,val,false);

                val -= Time.fixedDeltaTime * SpeedScale*8;
                yield return new WaitForSeconds(.01f);

            }
            HandleChildrenGroup(g,0,false);
            HandleNoChildrenGroup(g,0,false);
            HandleSpecialGroup(g,0,false);
        }
    }

    void SetActiveFlagOnMesh(MeshRenderer mesh, float active){
        foreach (Material mat in mesh.materials)
            SetActiveFlagOnMaterial( mat, active);
    }
    void SetActiveFlagOnMaterial(Material mat, float active){
        //Debug.Log("Set Active " + active);
        mat.SetFloat("_HighlightActive", active);
    }

    void SetFadeFlagOnMesh(MeshRenderer mesh, float active){
        foreach (Material mat in mesh.materials)
            SetFadeFlagOnMaterial( mat, active);
    }
    void SetFadeFlagOnMaterial(Material mat, float active){
        mat.SetFloat("_FadeActive", active);
    }



    void SetHighlightOnMesh(float amount, MeshRenderer mesh, bool up)
    {
        foreach (Material mat in mesh.materials)
            SetHighlightOnMaterial(amount, mat, up);
    }

    void SetHighlightOnMaterial(float amount, Material m,bool up)
    {
        float current = m.GetFloat("_HighlightAmount");
        float active  = m.GetFloat("_HighlightActive");
        if(up && current < amount)
            m.SetFloat("_HighlightAmount", amount);
        else if(!up && current > amount && active ==0)
            m.SetFloat("_HighlightAmount", amount);
    }
    float GetHighlightOnMaterial( Material m)
    {
        return m.GetFloat("_HighlightAmount");
    }
}
