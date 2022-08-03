using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryUI : MonoBehaviour
{
	public GameObject inventoryUI;
	Inventory inventory;
	FirstPersonController firstPersonController;
	MouseLook mouseLook;

	bool didOpen = false;//globalVariable
	//bool notOpen = true;
	void Awake()
	{

	}

	void Update()
	{
		if (Input.GetButtonDown("Inventory"))
		{
			inventoryUI.SetActive
			(!inventoryUI.activeSelf);

			//if (Input.GetButtonDown("Inventory"))
			//{

			//	didOpen = !didOpen;
			//	inventoryUI.SetActive(didOpen); 
                
				

			//	if (didOpen)
			//	{

			//		Cursor.lockState = CursorLockMode.None;
			//		Cursor.visible = true;


			//	}

			//	else
			//	{

			//		Cursor.lockState = CursorLockMode.Locked;
			//		Cursor.visible = false;

			//	}


			//}
		}
	}
}

