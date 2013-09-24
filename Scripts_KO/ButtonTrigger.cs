using UnityEngine;
using System.Collections;

public class ButtonTrigger : MonoBehaviour {

	// Use this for initialization
	public float buttonDepressAmount = .5f;
	Vector3 buttonStartPos;
	
	public Transform buttonTransform;
	public Transform bannersTransform;
	
	void Start () {
		buttonStartPos = buttonTransform.position;
		bannersTransform.gameObject.SetActive( false );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter( Collider other ) {
		
		Vector3 destination = buttonStartPos + Vector3.down * buttonDepressAmount;
		iTween.MoveTo( buttonTransform.gameObject, destination, .5f );
		bannersTransform.gameObject.SetActive( true );
		
	}
	
	void OnTriggerExit( Collider other ) {
		
		iTween.MoveTo( buttonTransform.gameObject, buttonStartPos, .5f );
		bannersTransform.gameObject.SetActive( false );
	}
}
