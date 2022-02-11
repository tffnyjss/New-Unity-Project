using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory3 : MonoBehaviour
{


    [SerializeField] public GameObject panel;
    public Text diamondCounter;
    public Text potionCounter;
    public Text foodCounter;


    private int diamonds = 0;
    private int potions = 0;
    private int food = 0;
    public void Start()
    {
        panel.SetActive(false);
    }


    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectables"))
        {
            Collect(other.GetComponent<Collectables>());

        }
    }
    private void Collect(Collectables collectables)
    {
        if (collectables.Collect())
        {
            if (collectables is Diamond)

            {
                Debug.Log("DiamondCollectables");
                diamonds++;

            }
            else if (collectables is Potion)

            {
                Debug.Log("PotionCollectables");
                potions++;

            }
            else if (collectables is Food)
            {
                Debug.Log("FoodCollectables");
                food++;

            }

            UpdateGUI();

        }
    }

    private void UpdateGUI()
    {
        if ((diamonds == 1) && (potions == 1))
        {
            OpenPanel();
        }

        diamondCounter.text = diamonds.ToString();
        potionCounter.text = potions.ToString();
        foodCounter.text = food.ToString();

    }
    void OpenPanel()
    {

        panel.SetActive(true);
    }


}