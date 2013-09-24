using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float offset = Time.fixedTime * .1f;
		
		this.renderer.material.SetTextureOffset( "_MainTex", new Vector2( -offset, 0 ) );
	}
}
