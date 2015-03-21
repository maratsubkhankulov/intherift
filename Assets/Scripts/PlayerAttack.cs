using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			Debug.Log("Attacking");
			Attack ();
		}
	}

	void Attack()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");

		foreach (var enemy in enemies) 
		{
			if (IsVisible(enemy))
			{
				Debug.Log ("Enemy seen");
			} else {
				Debug.Log ("not seen enemy");
			}
		}
	}

	bool IsVisible(GameObject o) {
		return o.renderer.isVisible;
	}

	void OnTriggerStay(Collider other) {

		var rotation = transform.rotation;

	}
}
