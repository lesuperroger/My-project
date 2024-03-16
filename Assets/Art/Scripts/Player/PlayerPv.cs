using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPv : MonoBehaviour
{
    public int pv = 3;
    public int maxPv = 3;
    // Start is called before the first frame update
    void Start()
    {
        pv = maxPv;
    }

    public void TakeDamage(int dm)
    {
        pv -= dm;
        if(pv <= 0)
        {
            Destroy(gameObject); 
        }

    }
}
