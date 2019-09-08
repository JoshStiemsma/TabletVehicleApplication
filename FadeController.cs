using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour {
    public List<GameObject> OuterObjects = new List<GameObject>();
    public List<GameObject> StructureObjects = new List<GameObject>();
    public List<GameObject> BatteryObjects = new List<GameObject>();
    public List<GameObject> MotorOjects = new List<GameObject>();
    public List<GameObject> ChassisOjects = new List<GameObject>();
    public List<GameObject> ElectricalWireOjects = new List<GameObject>();



    public List<MeshRenderer> OuterMeshes = new List<MeshRenderer>();
    public List<MeshRenderer> StructureMeshes = new List<MeshRenderer>();
    public List<MeshRenderer> BatteryMeshes = new List<MeshRenderer>();
    public List<MeshRenderer> MotorMeshes = new List<MeshRenderer>();
    public List<MeshRenderer> ChassisMeshes = new List<MeshRenderer>();
    public List<MeshRenderer> ElectricalWireMeshes = new List<MeshRenderer>();

    public List<BoxCollider> OuterAnimTriggers = new List<BoxCollider>();
    public List<BoxCollider> BatteryAnimTriggers = new List<BoxCollider>();
   
    public static FadeController self;
    private bool structure = true, Battery = true, Motor = true, Outer = true,Chassis = true,ElectricalWire = true;

    public Animator BatteryAnimator;
    private GameObject BatteryParent;
    private bool BatteryAnimated=false;
    public bool InitMeshsOnStart = false;


    //public GameObject Sensors; 
    private void Awake()
    {
        self = GetComponent<FadeController>();
        BatteryParent = BatteryAnimator.gameObject.transform.parent.gameObject;

    }
    // Use this for initialization
    void Start()
    { 
        //Cursor.visible = false;
        self = GetComponent<FadeController>();
        if(InitMeshsOnStart)
        InitMeshs();
        BatteryParent = BatteryAnimator.gameObject.transform.parent.gameObject;
    }

    float CurrentClipLength = 0, TimeAlongAnim=0;

    private float GetTimeAlongAnim()
    {
        AnimatorStateInfo animStat = BatteryAnimator.GetCurrentAnimatorStateInfo(0);
        AnimatorClipInfo[] animClip = BatteryAnimator.GetCurrentAnimatorClipInfo(0);
        CurrentClipLength = animClip[0].clip.length;
        float t = CurrentClipLength * animStat.normalizedTime;
        //return Mathf.Clamp01(t / CurrentClipLength);
        return t / CurrentClipLength;
    }
    private void Update()
    {
        Vector3 pos = BatteryParent.transform.localPosition;

       
        //if (BatteryAnimated) BatteryParent.transform.localPosition = Vector3.Lerp(pos, new Vector3(0, .5f, 0), Time.fixedDeltaTime*1.85f);
       // else BatteryParent.transform.localPosition = Vector3.Lerp(pos, Vector3.zero, (Time.fixedDeltaTime*.5f));
    }

    void GrabMeshes(List<GameObject> objs,ref List<MeshRenderer> meshList, List<List<MeshRenderer>> CrossRef)
    {
        meshList = new List<MeshRenderer>();
        foreach (GameObject obj in objs)
        {
            if (obj.GetComponent<MeshRenderer>() != null)
                meshList.Add(obj.GetComponent<MeshRenderer>());
            MeshRenderer[] children = obj.GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer m in children)
            {
                bool inOtherList = false;

                if (CrossRef != null)
                {
                    foreach (List<MeshRenderer> list in CrossRef)
                    {
                        if (list.Contains(m))
                            inOtherList = true;
                    }
                }
                if (!inOtherList)
                {
            Debug.Log("added "+ m.gameObject.name);

                    meshList.Add(m);
                }
            }
        }
    }
    void InitMeshs()
    {
        GrabMeshes(ChassisOjects,ref ChassisMeshes,null);
        GrabMeshes(MotorOjects, ref MotorMeshes, null);
        GrabMeshes(ElectricalWireOjects, ref ElectricalWireMeshes, null);

        GrabMeshes(BatteryObjects, ref BatteryMeshes, new List<List<MeshRenderer>>() { MotorMeshes });
        GrabMeshes(StructureObjects, ref StructureMeshes, new List<List<MeshRenderer>>() { MotorMeshes, BatteryMeshes });
        GrabMeshes(OuterObjects, ref OuterMeshes, new List<List<MeshRenderer>>() { MotorMeshes, BatteryMeshes,StructureMeshes });



        
        InitMeshsOnStart = false;
    }
    void UpdateColliders(bool outer, bool battery)
    {
        foreach (BoxCollider b in OuterAnimTriggers)
            b.enabled = outer;
        foreach (BoxCollider c in BatteryAnimTriggers)
            c.enabled = battery;
    }
    void CheckMeshVisablility(bool b,ref bool _b, List<MeshRenderer> meshs)
    {
        if (b && !_b)
        {
            SetFadeOnMeshes(meshs, true);
            _b = true;
        }
        else if (!b && _b)
        {
            SetFadeOnMeshes(meshs, false);
            _b = false;
        }
    }
    void UpdateSplit(bool outer,bool structure,bool battery, bool motor,bool chasis,bool wires)
    {
        SetSplitOnMesh(OuterMeshes, outer);
        SetSplitOnMesh(StructureMeshes, structure);
        SetSplitOnMesh(BatteryMeshes, battery);
        SetSplitOnMesh(MotorMeshes, motor);
        SetSplitOnMesh(ChassisMeshes, chasis);
    }
    void UpdateMeshVisablility(bool _outer, bool _structure, bool _battery, bool _motor, bool _chasis, bool _wires)
    {
        
        CheckMeshVisablility(_outer, ref Outer, OuterMeshes);
        CheckMeshVisablility(_structure, ref structure, StructureMeshes);
        CheckMeshVisablility(_battery, ref Battery, BatteryMeshes);
        CheckMeshVisablility(_motor, ref Motor, MotorMeshes);
        CheckMeshVisablility(_chasis, ref Chassis, ChassisMeshes);
        CheckMeshVisablility(_wires, ref ElectricalWire, ElectricalWireMeshes);

    }
    public void UpdateLayer(int i)
    {
        switch (i)
        {
            case 0://fullcar
                UpdateMeshVisablility(true, true, true, true, true, true);
                UpdateSplit(false, false, false, false, false, false);
                UpdateColliders(true,false);
                AnimatorController.instance.CloseAll();

                break;
            case 1://Structure no outer body
                UpdateMeshVisablility(true, true, true, true, true, true);
                UpdateSplit(true, false, false, false, false,false);
                UpdateColliders(true, false);
                AnimatorController.instance.SetBattery(false);
                break;
            case 2://no structure or body so at battery
                UpdateMeshVisablility(false, false, true, true, true, false);
                UpdateSplit(false, false, false, false, false, false);
                UpdateColliders(false, true);

                break;
            case 3://Motor with no chasis or wheels
                UpdateMeshVisablility(false, false, false, true, false, true);
                UpdateSplit(false, false, false, false, false, false);
                UpdateColliders(false, false);
                AnimatorController.instance.SetBattery(false);

                break;
            case 4://chassis leve with motor and batery
                UpdateMeshVisablility(false, false, true, true, true, true);
                UpdateSplit(false, false, false, false, false, false);
                UpdateColliders(false, false);
                AnimatorController.instance.SetBattery(false);

                break;
          
        }
    }
    void SetSplitOnMesh(List<MeshRenderer> meshs, bool split)
    {
        foreach (MeshRenderer mesh in meshs)
        {
            foreach (Material m in mesh.materials)
            {
                if (split)
                    m.SetFloat("_Split", 1);
                else
                    m.SetFloat("_Split", 0);
            }
        }
    }
    void SetFadeOnMeshes(List<MeshRenderer> meshs,bool visable)
    {

            StartCoroutine(StartFadeOn(meshs,visable,1f));
    }
    IEnumerator StartFadeOn(List<MeshRenderer> meshs, bool visable, float _time)
    {
        float time = 0f;
        float scaled =0;

        while (time < _time)
        {
            if(visable)
                scaled =  (time / _time);
            else
                scaled = 1f- (time / _time);

            foreach (MeshRenderer mesh in meshs)
            {
                foreach (Material m in mesh.materials)
                {

                    float cur = m.GetFloat("_Fade");

                    if (!visable && cur > 0)
                        cur -= Time.fixedDeltaTime*7f;
                    else if(visable && cur <1)
                        cur += Time.fixedDeltaTime*7f;

                     m.SetFloat("_Fade", cur);
                     mesh.enabled = scaled > .01f;
                }
            }

            time += Time.deltaTime;

            yield return new WaitForSeconds(.001f);
        }


        foreach (MeshRenderer mesh in meshs)
        {
            foreach (Material m in mesh.materials)
            {
                mesh.enabled = visable;
            }
        }


    }


}
