using UnityEngine;
using System.Collections;

public class EnemyWatch : MonoBehaviour {

	private Camera mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		foreach (GameObject enemy in enemies) {
			if (enemy != null)
			if (IsVisibleFrom (enemy.renderer, mainCamera)) {
				
				Debug.Log ("seen enemy");
			}
		}
	}

	public bool IsVisibleFrom(Renderer renderer, Camera camera)
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
}
