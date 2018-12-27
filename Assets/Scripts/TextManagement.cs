using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManagement : MonoBehaviour {
	public Text text;
	public Image sprite;

	private static Text sText;
	private static Image sSprite;

	// Use this for initialization
	void Start () {
		sText = text;
		sText.enabled = false;
		sSprite = sprite;
		sSprite.enabled = false;
	}
	
	public static void Popin(string value) {
		sText.text = value;
		sText.enabled = true;
		sSprite.enabled = true;
	}

	public static void Popoff() {
		sText.enabled = false;
		sSprite.enabled = false;
	}
}
