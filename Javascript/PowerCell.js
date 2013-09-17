#pragma strict

var rotationSpeed : float = 100.0f;

function Start () {

}

function Update () {
	
	// To rotate the powerCell
	
	transform.Rotate(Vector3 (0,rotationSpeed * Time.deltaTime, 0));
}

function OnTriggerEnter (col : Collider)
{
	if(col.gameObject.tag == "Player")
	{
		col.gameObject.SendMessage("CellPickup");
		Destroy(gameObject);
	}
}