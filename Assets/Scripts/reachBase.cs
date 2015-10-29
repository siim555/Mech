using UnityEngine;
using System.Collections;

public class reachBase : MonoBehaviour {
    public float playerHealth;
    public static float playerHealthGUI;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        playerHealthGUI = playerHealth;
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "NPC")
        {
            Destroy(other.gameObject);
            playerHealth = playerHealth - 1;
            enemySpawn.enemyexists = false;
        }

    }

}
