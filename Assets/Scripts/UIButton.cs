using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler {
	[SerializeField]
	public Character.type type;

	[SerializeField]
	GameObject CharInfoMessage;

	[SerializeField]
	int id;
	bool isOver;
	// Use this for initialization
	void Start () {
		
	}

	public void OnPointerEnter(PointerEventData eventData){


		//	CharInfoMessage.SetActive (true);
		//	CharInfoMessage.transform.position = Input.mousePosition;
		
	}
	public void OnPointerDown(PointerEventData eventData){

		GetComponentInParent<SelectionManager> ().updateSelection (type,id);
	}
	public void OnPointerExit(PointerEventData eventData){

	//	CharInfoMessage.SetActive (false);

	}
	// Update is called once per frame
	void Update () {
		if (isOver) {


		} else {


		}

	}
}
