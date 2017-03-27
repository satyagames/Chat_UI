using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChatBoxFunctions : MonoBehaviour {

	[SerializeField] ContentSizeFitter contentSizeFitter;
	[SerializeField] Text showHideButtonText;
	bool isChatShowing = false;
	string message = "";

	public void Start()
	{
		ToggleChat ();
	}

	public void ToggleChat()
	{
		isChatShowing = !isChatShowing;
		if(isChatShowing)
		{
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			//contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
			showHideButtonText.text = ">";
		}
		else
		{
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.MinSize;
			//contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.MinSize;
			showHideButtonText.text = "<";
		}

	}
	public void SetMethod(string message)
	{
		this.message = message;
	}
	public GameObject messageParentPanel;
	public GameObject newMessagePrefab;

	public void ShowMessage()
	{
		//if(message != "")
		//{
		GameObject clone = (GameObject)Instantiate(newMessagePrefab);
			clone.transform.SetParent(messageParentPanel.transform,false);
		clone.transform.SetSiblingIndex(messageParentPanel.transform.childCount - 2);
		clone.GetComponent<MassageFunction>().ShowMag(message);
		//}
	}
}
