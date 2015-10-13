using UnityEngine;
using System.Collections;

public class BuildingManage : MonoBehaviour {
	public GUISkin customerSkin;
	public GameObject[] buildings;
	private BuildingPlacement buildingPlacement;
	// Use this for initialization
	void Start () {
		buildingPlacement = GetComponent<BuildingPlacement> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI(){
		GUI.skin = customerSkin;
		for (int i=0; i<buildings.Length; i++) {
			if(GUI.Button(new Rect(Screen.width/20,Screen.width/15+Screen.height/12*i+Screen.height/12*3,100,30),buildings[i].name))
				buildingPlacement.SetItem(buildings[i]);
		}
	}
}
