using UnityEngine;
using System.Collections;

public class TowerMovement : MonoBehaviour {
	public float moveSpeed = 4.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
		Vector3 dir = Vector3.zero;
		if (Input.acceleration.x >= 0.05) {
			dir.x = Input.acceleration.x;
		}
		if (Input.acceleration.x <= -0.05) {
			dir.x = Input.acceleration.x;
		}
		if (dir.sqrMagnitude > 1){
			dir.Normalize();
		}
		dir *= Time.deltaTime;
		transform.Translate(dir * moveSpeed);

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * moveSpeed);
        //}

        // if (Input.GetKey(KeyCode.UpArrow))
        //	{
        //			transform.Translate(new Vector3(0, 1, 0)*Time.deltaTime*moveSpeed);
        //	}

        //	if (Input.GetKey(KeyCode.DownArrow))
        //  {
        //		transform.Translate(new Vector3(0, -1, 0)*Time.deltaTime*moveSpeed);
        //	}
    }
}
