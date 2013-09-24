using UnityEngine;
using System.Collections;

public class MovingBoxes : MonoBehaviour 
{
	//Reference to array of boxes
	public GameObject[] Boxes;
	
	//Translate speed of boxes
	public Vector3 TranslateSpeed = Vector3.zero;
	
	//Max Y limit to reach before elevating next box
	public float MaxY = 20.0f;
	
	IEnumerator MoveBoxes()
	{
		yield return new WaitForSeconds(2.0f);
		
		//Move boxes in turn
		foreach(GameObject Box in Boxes)
		{
			while(Box.transform.position.y < MaxY)
			{
				Box.transform.Translate(TranslateSpeed.x * Time.deltaTime, TranslateSpeed.y * Time.deltaTime, TranslateSpeed.z * Time.deltaTime);
				yield return null;
			}
		}
			
		yield return new WaitForSeconds(1.0f);
			
		Debug.Log ("Sequence Completed");
	}
	
	// Use this for initialization
	void Start ()
	{
		StartCoroutine("MoveBoxes");
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}