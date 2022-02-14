using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Image timeImage;
    [SerializeField] Text timeText;
    [SerializeField] float duration, currentTime;

    public AudioSource gameover;
    public AudioSource sceneone;

    // Start is called before the first frame update
    void Start()
        
    {
        sceneone.Play();
        panel.SetActive(false);
        currentTime = duration;
        timeText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());


    }
    IEnumerator TimeIEn()
    {
        while (currentTime >= 0)
        {
           // sceneone.Play();
            timeImage.fillAmount = Mathf.InverseLerp(0, duration, currentTime);
            timeText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;

            

        }
        OpenPanel();
    }
    void OpenPanel()
    {
        timeText.text = "";
        panel.SetActive(true);
        sceneone.Stop();
        gameover.Play();
    }
    public void Retry(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

}