using UnityEngine;
using System.Collections;

public class sth : MonoBehaviour {
	public float speed = 1;
    public float health = 500;
    public static float enemyHealth;
	// Use this for initialization
	void Start () {
		//transform.Rotate(new Vector3(0, 0, 1), 90);
	}
	
	// Update is called once per frame
	void Update ()
	{

        enemyHealth = health;
        if (GameObject.FindGameObjectWithTag("tower") != null)
        {

            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        }
        //transform.Translate (speed, 0, 0);
		//transform.Rotate(new Vector3(1, 0, 0), 90);
		//if (transform.position.x <= 3) {
		//transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * speed);
		//}
		//else {
		//transform.Translate (new Vector3 (0, -1, 0) * Time.deltaTime * speed);
		//}
		if (transform.position.x >= 4.5) {
			Destroy (gameObject);
		}
	
		}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Enemy Hit " + other.gameObject.tag);

        if (other.gameObject.tag == "bullet")
        {

            if (health == 50)
            {
                Debug.Log("Enemy Destroyed");
                Destroy(gameObject);
                enemySpawn.enemyexists = false;
            }
            else
            {
                health = health - 50;
                Debug.Log("Health Reduced" + health);
                enemySpawn.enemyexists = true;
            }
        }

    }

   
}