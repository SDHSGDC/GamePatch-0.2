using UnityEngine;
using System.Collections;

public class IntroMessage : MonoBehaviour {

	public int timeToShow;

	// Use this for initialization
	void Start () {
		StartCoroutine(DeleteUI (timeToShow));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator DeleteUI(float seconds){
//		Debug.Log ("Coroutine Started");
		yield return new WaitForSeconds (seconds);
		Destroy (gameObject);
//		Debug.Log ("Coroutine Ended");
	}
}
