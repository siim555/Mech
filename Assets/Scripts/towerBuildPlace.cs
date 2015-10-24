using UnityEngine;
using System.Collections;
// Marc Ki-Fun
// 15/10/2015
public class towerBuildPlace : MonoBehaviour {
	public GameObject towerPrefab; //The tower that should be built
	private bool railOnTower = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Called when Mouse has been clicked on object
	void OnMouseUpAsButton(){
		//build tower above object
		if (!railOnTower){ // check it a tower has already been built
			GameObject g = (GameObject)Instantiate (towerPrefab); // create instant of tower
			g.transform.position = transform.position;
			railOnTower = true;
		}	
	}
}
