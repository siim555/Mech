using UnityEngine;
using System.Collections;

public class TowerMovement : MonoBehaviour {
	public float moveSpeed = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * moveSpeed);
        }

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
