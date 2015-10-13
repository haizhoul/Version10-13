using UnityEngine;
using System.Collections;

public class navigate1 : MonoBehaviour 

{
	Transform target;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.
	public float Time = 10f;            // How long between each spawn.
	public GameObject player;
	public Camera camera;  
	private string name = "Tired"; // headtag
	
	
	
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag("MainCamera");  
		camera = Camera.main; 
		// Set up the references.
		target = GameObject.FindGameObjectWithTag ("building1").transform;
		
		nav = GetComponent <NavMeshAgent> ();
		nav.SetDestination (target.position);
		InvokeRepeating ("Change", Time, Time);
	}
	void Update ()
	{
		
		// ... set the destination of the nav mesh agent to the player.
		nav.SetDestination (target.position);

		
	} 
	void Change()
	{
		target = GameObject.FindGameObjectWithTag ("dead").transform;
		name = "Nice~"; //change head tag
		Cash.cash += 100; //adding money
		satisfaction.sat += 1;
		nav = GetComponent <NavMeshAgent> ();
		nav.SetDestination (target.position);
		DestroyObject (nav,10f);
	}
	
	void OnGUI()  
	{  
		//得到NPC头顶在3D世界中的坐标  
		Vector3 worldPosition = new Vector3(transform.position.x, transform.position.y + 0.8f, transform.position.z);  
		//根据NPC头顶的3D坐标换算成它在2D屏幕中的坐标  
		Vector2 position = camera.WorldToScreenPoint(worldPosition);  
		//得到真实NPC头顶的2D坐标  
		position = new Vector2(position.x, Screen.height - position.y);  
		//计算NPC名称的宽高  
		Vector2 nameSize = GUI.skin.label.CalcSize(new GUIContent(name));  
		//设置显示颜色为黄色  
		GUI.color = Color.blue;  
		//绘制NPC名称  
		GUI.Label(new Rect(position.x - (nameSize.x / 2), position.y - nameSize.y, nameSize.x, nameSize.y), name);  
		
	}  
	
	//
	
	
	
	
	
}