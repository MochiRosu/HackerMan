using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMission1Scene()
    {
        SceneManager.LoadScene("Mission 1");
    }
    public void LoadMission2Scene()
    {
        SceneManager.LoadScene("Mission 2");
    }
    public void LoadMission3Scene()
    {
        SceneManager.LoadScene("Mission 3");
    }

    public void LoadMissionListScene()
    {
        SceneManager.LoadScene("MissionList");
    }
}
