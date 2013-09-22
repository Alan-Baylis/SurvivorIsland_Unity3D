using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	public GUITexture  fadeWhite;
	
	public static int charge = 0;
	public AudioClip collectSound;
	bool fireIsLit = false;
	
	// HUD
	public Texture2D[] hudCharge;
	public GUITexture chargeHudGUI;
	
	// Generator
	public Texture2D[] meterCharge;
	public Renderer meter;
	
	// Matches
	bool haveMatches = false;
	public GUITexture matchGUIprefab;
	GUITexture matchGUI;
	
	// Text
	public GUIText textHints;
	
	// Winning Animation
	
	public GameObject winObj;

	// Use this for initialization
	void Start () {
		charge = 0;
		meter.material.mainTexture = meterCharge[charge];
		
		Instantiate(fadeWhite);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void CellPickup()
	{
		HUDon();
		AudioSource.PlayClipAtPoint(collectSound,transform.position);
		charge++;
		
		chargeHudGUI.texture = hudCharge[charge];
		
		meter.material.mainTexture = meterCharge[charge];
		
	}
	
	void HUDon()
	{
		if(!chargeHudGUI.enabled)
		{
			chargeHudGUI.enabled = true;
		}
	}
	
	void MatchPickup()
	{
		haveMatches = true;
		AudioSource.PlayClipAtPoint(collectSound,transform.position);
		GUITexture matchHUD = Instantiate(matchGUIprefab, new Vector3 (0.15f, 0.1f,0), transform.rotation) as GUITexture;
		matchGUI = matchHUD;
	}
	
	void OnControllerColliderHit (ControllerColliderHit col)
	{
		if(col.gameObject.name == "campfire")
		{
			if(haveMatches && !fireIsLit)
			{	
				Lightfire(col.gameObject);
			}
			else if (!haveMatches && !fireIsLit)
			{
				textHints.SendMessage("ShowHint","I could use this campfire to signal for help..if only I could light it up");
			}
		}
	}
	
	void Lightfire(GameObject campfire)
	{
		campfire.GetComponentInChildren<ParticleSystem>().Play();
		
		campfire.audio.Play();
		Destroy (matchGUI);
		haveMatches = false;
		fireIsLit = true;
		winObj.SendMessage("GameOver");
		
		
	}
}
