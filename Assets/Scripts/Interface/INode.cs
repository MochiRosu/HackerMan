using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INode
{
    public static string ID = "00";

    public static string Description;


    // hey rosco when creating a node right next to monobehaviour put INode than write in the brackets public overide void Interface() and write you code
    /// <summary>
    /// Interface with The Node 
    /// </summary>
    public virtual void Interface()
    {
        Debug.Log("This is the Default Interface and Has not been Implmented yet please overide this function to create default behaviour");
    }
}
