using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
[System.Serializable]
public class INode : MonoBehaviour
{
    [SerializeField] public string ID = "00";
    [SerializeField] public string Name = "Blank";
    [SerializeField] public string Description;
    [SerializeField] public List<INode> NodesNTM = new();

    [SerializeField] TMP_Text IDTEXT;

    public LineRenderer baseLineRenderer;

    public List<LineRenderer> line = new();

    public ParticleSystem Particalse;

    // hey rosco when creating a node right next to monobehaviour put INode than write in the brackets public overide void Interface() and write you code
    /// <summary>
    /// Interface with The Node 
    /// </summary>
    public virtual void Interface()
    {
        Debug.Log("This is the Default Interface and Has not been Implmented yet please overide this function to create default behaviour");
    }

    public void Start()
    {
        foreach (var node in NodesNTM)
        {
            LineRenderer li = CopyComponent<LineRenderer>(baseLineRenderer, this.gameObject);

            li.positionCount = 2;
            li.SetPosition(0, node.gameObject.transform.position);
            li.SetPosition(1, this.gameObject.transform.position);
            line.Add(li);
        }
        //Destroy(baseLineRenderer);
    
        IDTEXT.text = ID.ToUpper();
    }

    public void Update()
    {
        IDTEXT.transform.LookAt(Camera.main.transform.position);
        IDTEXT.transform.localEulerAngles = new Vector3(180, 180, 180);
    }

    T CopyComponent<T>(T original, GameObject destination) where T : Component
    {
        System.Type type = original.GetType();
        var dst = destination.GetComponent(type) as T;
        if (!dst) dst = destination.AddComponent(type) as T;
        var fields = type.GetFields();
        foreach (var field in fields)
        {
            if (field.IsStatic) continue;
            field.SetValue(dst, field.GetValue(original));
        }
        var props = type.GetProperties();
        foreach (var prop in props)
        {
            if (!prop.CanWrite || !prop.CanWrite || prop.Name == "name") continue;
            prop.SetValue(dst, prop.GetValue(original, null), null);
        }
        return dst as T;
    }
}