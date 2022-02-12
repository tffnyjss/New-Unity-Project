using UnityEngine;


public class GamePreferenceManager : MonoBehaviour
{
    count string Level = "LevelNum";

    void Start()
    {
        LoadPrefs();
    }

    void OnApplicationQuit()
    {
        SavePrefs();
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetInt("Level", GameViewController.Instance.CurrentLevel);
        PlayerPrefs.Save();
    }

    public void LoadPrefs()
    {
        var score = PlayerPrefs.GetInt("Level", 0);
        GameViewController.Instance.CurrentLevel = Level;
    }
}
   