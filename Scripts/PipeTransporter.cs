using UnityEngine;
using System.Collections;

public class PipeTransporter : MonoBehaviour {

	public int effectiveDistance = 0;
	public int desiredLevel = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.DrawRay (this.transform.position, Vector3.down);

		Ray pipeRay = new Ray (this.transform.position, Vector3.down);
		RaycastHit hit;

		if(Physics.Raycast(pipeRay, out hit, effectiveDistance)) {

			if(hit.transform.tag == "Player"){
				Debug.Log ("Hit Player");
//				Application.LoadLevel(desiredLevel);
				hit.transform.Translate(0,1,0);
			}

		}
	
	}

}
