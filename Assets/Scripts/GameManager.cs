using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int PlayerRounds = 0;

    public int playerActionsLeft = 2;

    public int Money = 0;


    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }else
        {
            Destroy(this);
        }
    }

    public void ActionTaken()
    {
        playerActionsLeft--;
        if(playerActionsLeft == 0)
        {
            playerActionsLeft = 2;
            PlayerRounds++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
