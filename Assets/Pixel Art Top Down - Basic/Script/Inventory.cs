using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectables"))
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

            }
            else if (collectables is Potion)
            {
                Debug.Log("PotionCollectables");

            }
        }
    }
}
