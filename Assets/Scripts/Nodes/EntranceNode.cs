using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntranceNode : INode
{
    public override void Interface()
    {
        Debug.Log("Entrance and Exit Node");
        SceneManager.LoadScene("MissionList");
    }

    // Start is called before the first frame update
   
}
