using UnityEngine;
using System.Collections;

public class BuildingPlacement : MonoBehaviour {
	private BuildingPlacable buildingPlacable;
	private Transform currentBuilding;
	private bool hasPlaced;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentBuilding != null && currentBuilding !=hasPlaced) {
			Vector3 m=Input.mousePosition;
			m=new Vector3(m.x,m.y,transform.position.y);
			Camera camera = GetComponent<Camera>();
			Vector3 p=camera.ScreenToWorldPoint(m);
			currentBuilding.position=new Vector3(p.x,0.45f,p.z+1);
			if(Input.GetMouseButtonDown(0))
				if(IsLegalPosition())
					hasPlaced=true;
		}
	}
	bool IsLegalPosition(){
		if (buildingPlacable.colliders.Count > 0)
			return false;
		return true;
	}
	public void SetItem(GameObject b){
		hasPlaced = false;
		currentBuilding =( (GameObject)(Instantiate (b))).transform;
		buildingPlacable=currentBuilding.GetComponent<BuildingPlacable>();
		Cash.cash -= 1000; // jian fangzi jian qian
	}
}
