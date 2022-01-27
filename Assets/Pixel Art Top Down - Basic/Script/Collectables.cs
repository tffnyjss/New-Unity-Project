using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isCollected = false;
    public bool Collect()
    {
        if (isCollected)
            return false;
        isCollected = true;
        Destroy(gameObject);
        return true;

    }
}
