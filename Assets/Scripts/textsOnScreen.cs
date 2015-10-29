using UnityEngine;
using System.Collections;

public class textsOnScreen: MonoBehaviour {
public GameObject enemy;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        enemy = GameObject.FindGameObjectWithTag("NPC");



    }



    void OnGUI()
    {
            GUI.Label(new Rect(10, 10, 100, 20), "Player health:" + reachBase.playerHealthGUI.ToString());
            GUI.Label(new Rect(1100, 10, 100, 20), sth.enemyHealth.ToString());
    }
    
}
