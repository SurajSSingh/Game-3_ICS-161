using UnityEngine;
using System.Collections;

public class ScrollTexture : MonoBehaviour {

	public Vector2 scrollSpeed;
	private Vector2 currentOffset;

	void Update () {
		
		currentOffset += scrollSpeed * Time.deltaTime;
		GetComponent<Renderer>().material.SetTextureOffset( "_MainTex", currentOffset);

	}
}
