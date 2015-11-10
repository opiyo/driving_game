using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {
	
	void Update (){
		transform.Translate (new Vector3(-0.1f,0,0));
		if (transform.position.z < Camera.main.transform.position.z) {
			Destroy (gameObject);
		}
	}
	
}