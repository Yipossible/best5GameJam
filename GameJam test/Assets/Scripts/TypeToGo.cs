using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TypeToGo : MonoBehaviour {

	private BoatMoveBackward boatMoveBackward;

	public Rigidbody boat;
	// Use this for initialization
	void Start () {
		var input = gameObject.GetComponent<InputField> ();
		var boatMoveBackward = GetComponent<BoatMoveBackward> ();
		var typeEvent = new InputField.SubmitEvent ();
		typeEvent.AddListener (GoForward);
		input.onEndEdit = typeEvent;
	}

	// Update is called once per frame
	void GoForward (string input) {
		Debug.Log ("user type" + input);
		boat = boatMoveBackward.GetComponent<Rigidbody> ();
		if ( input.Contains("hello"))
			
		boat.transform.Translate (Time.deltaTime * 50, 0, 0);
	}
}
