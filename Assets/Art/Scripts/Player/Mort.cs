using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mort : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject skull;
    private Transform skullSpawn;
    private Transform skullshape;
    private GameObject instatiedobj;
   public void DeathMecha() 
   {
        InstantiateSkull();
        SkullInflate1();
        SkullInflate2();
        SkullInflate3();
        SkullInflate4();
        MenuRetry();
   }
    private void InstantiateSkull() 
    {
        skullSpawn = gameObject.GetComponent<Transform>();
        instatiedobj = Instantiate(skull, skullSpawn.position, Quaternion.identity);
    }
    private void SkullInflate1() 
    {
        skullshape = instatiedobj.GetComponent<Transform>();
        skullshape.localScale = new Vector3(0.5f,0.5f,0.5f);
        skullshape = instatiedobj.GetComponent<Transform>();
    }
    private void SkullInflate2()
    {
        skullshape.localScale = new Vector3(1f, 1f, 1f);
        skullshape = instatiedobj.GetComponent<Transform>();
    }
    private void SkullInflate3()
    {
        skullshape.localScale = new Vector3(3f, 3f, 3f);
        skullshape = instatiedobj.GetComponent<Transform>();
    }
    private void SkullInflate4()
    {
        skullshape.localScale = new Vector3(6f, 6f, 6f);
    }
    private void MenuRetry()
    {
        Destroy(instatiedobj);
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
        else
            Debug.Log("gameOverPanel n'est pas inclu dans le script de mort de PlayerJouet");
    }
}
