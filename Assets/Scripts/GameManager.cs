using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int PlayerRounds = 0;

    public int playerActionsLeft = 2;

    public int Money = 0;
    public int MaxRoundsForLevel;

    public TMP_Text money;
    public static GameManager instance;

    public TMP_Text Round;

    public GameObject R1, R2;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            Money = PlayerPrefs.GetInt("Money", 0);
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
        money.text = Money.ToString();

        Round.text = $"{PlayerRounds}/{MaxRoundsForLevel}";

        if(PlayerRounds == MaxRoundsForLevel)
        {
            SceneManager.LoadScene("MissionList");
        }

        switch(playerActionsLeft)
        {
            case 0:
                R1.SetActive(true);
                R2.SetActive(true);
                break;
            case 1:
                R1.SetActive(true);
                R2.SetActive(false);
                break;

            case 2:
                R1.SetActive(false);
                R2.SetActive(false);
                break;
        }
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Money", Money);
        PlayerPrefs.Save();
    }

    
}
