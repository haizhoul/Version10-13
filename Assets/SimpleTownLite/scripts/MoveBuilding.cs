using UnityEngine;
using System.Collections;

public class MoveBuilding : MonoBehaviour {

	private RaycastHit raycastHit;
	private GameObject Gobj;
	private float distance;
	private Vector3 ObjPosition;
	private bool Bobj;
	
	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButton (0)) {
			var ray = GetComponent<Camera> ().ScreenPointToRay (Input.mousePosition);
			var hit = Physics.Raycast (ray.origin, ray.direction, out raycastHit);
			
			if (hit && !Bobj) {
				Gobj = raycastHit.collider.gameObject;
				distance = raycastHit.distance;
				Debug.Log (Gobj.name);
			}
			
			Bobj = true;
			ObjPosition = ray.origin + distance * ray.direction;
			if (Gobj!=null && (Gobj.tag == "building1" || Gobj.tag == "building2" || Gobj.tag == "building3" || Gobj.tag == "billboard")) {

				Gobj.transform.position = new Vector3 (ObjPosition.x, Gobj.transform.position.y, ObjPosition.z);
			}
		} else {
			Bobj = false;
			Gobj = null;
		}       
	}
}

