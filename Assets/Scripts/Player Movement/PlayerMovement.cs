using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public INode currentNode;

    public static PlayerMovement instance;
    public TMP_Text description;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        transform.position = currentNode.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        description.text = currentNode.Description;
    }

    public void SelectCommand(string args)
    {
        string[] split = args.Split(' ');

        switch(split[0].ToLower())
        {
            case "move":
                
                Debug.Log("PlayerTriedMoving");
                foreach(INode c in currentNode.NodesNTM)
                {
                    Debug.Log(c.ID);
                    if(c.ID.ToLower() == split[1].ToLower())
                    {
                        currentNode = c;
                        transform.position = currentNode.transform.position;
                        c.Particalse.Play();
                        description.text = c.Description;
                        Camera.main.GetComponent<CameraShake>().Shake(0.5f,1f);
                        GameManager.instance.ActionTaken();
                        break;
                    }

                }
                break;
            case "interface":
                currentNode.Interface();
                GameManager.instance.ActionTaken();
                break;

        }
    }
}
