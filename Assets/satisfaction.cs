using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class satisfaction : MonoBehaviour 
	
{
	public static int sat;        // The player's score.
	Text text;  // Reference to the Text component.
	private GameObject[] buildings;
	public float Time = 0.3f; 
	void Awake()
	{
		// Set up the reference.
		text = GetComponent<Text>();
		// Reset the score.
		sat = 0;
//	InvokeRepeating ("Change",0,1f);
		
		
	}
	void Update()
	{
		
		//InvokeRepeating ("Change",0,0.3f);
		
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "satisfaction: " + sat;
	}
//	void Change()
//	{
//		sat = sat + 1;
//	}
}