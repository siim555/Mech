
using UnityEngine;
using System.Collections;

public class BulletSpawn : MonoBehaviour {
	
    public static GameObject firstenemy1;
    private float deltaFrame = 0;
    public float bulletSpawnInterval;
    //defining speed of bullet
    
    public GameObject bulletPrefab;
    


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        deltaFrame = deltaFrame + 1;



        //check if tower has been built:
        if (GameObject.Find("firstenemy(Clone)") && (deltaFrame % bulletSpawnInterval == 0))
        {
		GameObject b = Instantiate(bulletPrefab);
        b.transform.position = transform.position;
		}    

	}

}
