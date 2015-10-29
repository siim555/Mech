
using UnityEngine;
using System.Collections;

public class BulletSpawn : MonoBehaviour {
	
    public static GameObject firstenemy1;
    private float deltaFrame = 0;
    public float bulletSpawnInterval;
    public GameObject bulletPrefab;
    private float x;
    private float y;
    private float distance;
    public float range;
   
	// Use this for initialization
	void Start () {

        
        
	}
	
	// Update is called once per frame
	void Update () {
        deltaFrame = deltaFrame + 1;                                                                                //frame counter

        if (enemySpawn.enemyexists == true)
        {
    

            firstenemy1 = GameObject.FindGameObjectWithTag("NPC");
            distance = Vector3.Distance(firstenemy1.transform.position, gameObject.transform.position);



            if (distance <= range)                                                                                      //check if enemy is within range
            {

                if (deltaFrame % bulletSpawnInterval == 0)                 //check if tower has been built and current frame
                {
                    GameObject b = Instantiate(bulletPrefab);
                    b.transform.position = transform.position;
                }

            }
        }
	}

}
