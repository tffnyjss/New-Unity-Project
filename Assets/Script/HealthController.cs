using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField] public GameObject panel;
    public int playerHealth;
    public AudioSource gameover;
    public AudioSource sceneone;

    [SerializeField] private Image[] hearts;
    private void Start()
    {
        panel.SetActive(false);
        sceneone.Play();
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                hearts[i].color = Color.red;

            }
            else
            {
                hearts[i].color = Color.black;
            }

        }
        if (playerHealth == 0)
        {
            Debug.Log("Hearts");
            
            OpenPanel();
        }

        void OpenPanel()
        {

            panel.SetActive(true);
            sceneone.Stop();
            gameover.Play();
        }

    }
}
