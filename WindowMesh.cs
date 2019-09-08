using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMesh : MonoBehaviour {

    public float MaxWindowTransparancy = 0;
    public bool set = false;
   public  void SetValue()
    {
        if (set)
            return;
        MaxWindowTransparancy = GetComponent<MeshRenderer>().material.GetFloat("_Fade");
        set = true;

    }

    void Start()
    {
        if (set)
            return;
        //Debug.Log("Grabe fade windows");
        set = true;
        MaxWindowTransparancy = GetComponent<MeshRenderer>().material.GetFloat("_Fade");
    }
     void Awake()
    {
        if (set)
            return;
        //Debug.Log("Grabe fade windows");
        set = true;
        MaxWindowTransparancy = GetComponent<MeshRenderer>().material.GetFloat("_Fade");
    }
}
