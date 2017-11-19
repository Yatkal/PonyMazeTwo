using UnityEngine;
using System.Collections;

public class AlwaysAtParentScript : MonoBehaviour {

    GameObject parent;
    GameObject thisobject;

	// Use this for initialization
	void Start () {
        parent = transform.parent.gameObject;
        thisobject = gameObject;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 thisVector = new Vector3(1f, 1f, 1f);
        thisobject.transform.localPosition = Vector3.zero;
        thisobject.transform.localRotation = Quaternion.identity;
        thisobject.transform.localScale = thisVector;
	}
}
