using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cash : MonoBehaviour 

	{
		public static int cash;        // The player's score.
		Text text;  // Reference to the Text component.
		private GameObject[] buildings;
		//public float Time = 3f; 
		void Awake()
		{
			// Set up the reference.
			text = GetComponent<Text>();
			// Reset the score.
			cash = 2000;
//		InvokeRepeating ("Change",0,3f);
			
			
		}
		void Update()
		{
			
			//InvokeRepeating ("Change",0,0.3f);
			
			// Set the displayed text to be the word "Score" followed by the score value.
			text.text = "Cash: " + cash;
		}
//		void Change()
//		{
//			cash = cash + 10;
//		}
	}