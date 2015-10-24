using UnityEngine;
using System.Collections;

public class bulletMove : MonoBehaviour {
    public float speed;
    private float bulletspeed;
    //private float deltaFrame = 0;
	// Use this for initialization
	void Start () {
        bulletspeed = speed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
      
        
            transform.position = Vector3.MoveTowards(transform.position, GameObject.FindWithTag("NPC").transform.position, bulletspeed);
            //deltaFrame = 0;
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {

       if (other.gameObject.tag == "NPC")
        {
            Destroy(gameObject);
        }

    }
}
