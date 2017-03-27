using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassageFunction : MonoBehaviour {
	[SerializeField] Text text;
	public void ShowMag(string msg)
	{
		text.text = msg;
	}
}
