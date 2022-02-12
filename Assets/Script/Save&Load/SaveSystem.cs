using UnityEngine;

public class SaveSystem : MonoBehaviour
{
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
        PlayerPrefs.SetInt(ScoreKey, GameViewController.Instance.CurrentScore);
        PlayerPrefs.Save();
    }

    public void LoadPrefs()
    {
        var score = PlayerPrefs.GetInt(ScoreKey, 0);
        GameViewController.Instance.CurrentScore = score;
    }
}
   