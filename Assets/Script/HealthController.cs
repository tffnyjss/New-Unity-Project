using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int playerHealth;
    [SerializeField] private Image[] hearts;
    private void Start()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        for(int i=0;i<hearts.Length;i++)
        {
            if(i<playerHealth)
            {
                hearts[i].color= Color.red;

            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
        if(playerHealth == 0)
        {
            SceneManager.LoadScene(7);
        }
    }

}
