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
		sSprite = sprite;
	}
	
	public static void UpdateText(string value) {
		sText.text = value;
		sSprite.enabled = true;
	}
}
