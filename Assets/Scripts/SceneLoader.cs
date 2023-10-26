using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMission1Scene()
    {
        SceneManager.LoadScene("Mission1");
    }
    public void LoadMission2Scene()
    {
        SceneManager.LoadScene("Mission2");
    }
    public void LoadMission3Scene()
    {
        SceneManager.LoadScene("Mission3");
    }

    public void LoadMissionListScene()
    {
        SceneManager.LoadScene("MissionList");
    }
}
