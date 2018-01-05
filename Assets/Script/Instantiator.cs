using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour {

	//Numero de la derniere room
	public int NumRoom;
	//L'Objet qui va etre instantier 
	GameObject RoomClone;
	//Le prefab
	public GameObject Room;

	//La derniere Room
	GameObject LastRoom;

	// Use this for initialization
	void Start () {
		NumRoom = 3;
		//Debug.Log    ("Room" + (NumRoom-2).ToString())    ;
	}
	
	// Update is called once per frame
	void Update () {
        
		LastRoom = GameObject.Find ("Room" + NumRoom.ToString ());

		//Si on ne trouve pas la room la plus ancienne on en creer une autre 
		if (GameObject.Find ("Room" +(( NumRoom)-2).ToString()) == null)//objet est detruit  
		{
			RoomClone = Instantiate (Room, new Vector2 (0, LastRoom.transform.position.y + 8.21f), Quaternion.identity) as GameObject;
		    RoomClone.name = ("Room"+(NumRoom+1).ToString());
			NumRoom++;
		
		}

	}
}
