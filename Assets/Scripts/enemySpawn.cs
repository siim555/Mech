using UnityEngine;
using System.Collections;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public static bool enemyexists;
    // Use this for initialization
    void Start()
    {
    
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyexists == false)
        { // if there is no enemy in the game
            Debug.Log("SPAWN");
            GameObject g = (GameObject)Instantiate(enemy); // create instant of enemy
            g.transform.position = transform.position;
            enemyexists = true;
        }


    }

}
