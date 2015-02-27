using UnityEngine;
using System.Collections;

public class GUIforQuiz : MonoBehaviour 
{
	private int NumOfCorrect = 0;
	private static int level = 1;
	private float timer = 30 ;
	
	void Level1 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 1. When did Singapore become independent?");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. 9 March 1954")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 2;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. 3 April 1984")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 2;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. 9 August 1965")) 
		{
			//Application.LoadLevel(3);
			NumOfCorrect += 1;
			level = 2;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. 16 November 1975")) 
		{
			//Application.LoadLevel(4);
			Debug.Log("No");
			level = 2;
		}
	}
	//private bool handleTap(hit.collider.gameObject);
	void Level2 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 2. What does Singapore mean??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. Garden City")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 3;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. Lion City")) 
		{
			//Application.LoadLevel(2);
			NumOfCorrect += 1;
			level = 3;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. Freetown")) 
		{
			//Application.LoadLevel(3);
			Debug.Log ("No");
			level = 3;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. Yengema")) 
		{
			//Application.LoadLevel(4);
			Debug.Log("No");
			level = 3;
		}
	}
	
	void Level3 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 3. Which is the currency of Singapore??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. Dollar")) 
		{
			//Application.LoadLevel(1);
			NumOfCorrect += 1;
			level = 4;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. Lats")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 4;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. Pound")) 
		{
			//Application.LoadLevel(3);
			Debug.Log ("No");
			level = 4;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. Baht")) 
		{
			//Application.LoadLevel(4);
			Debug.Log("No");
			level = 4;
		}
	}
	
	void Level4 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 4. What is the symbolism of crescent on Singapore's flag??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. Growth of a young country")) 
		{
			//Application.LoadLevel(1);
			NumOfCorrect += 1;
			level = 5;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. Islam")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 5;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. Hinduism")) 
		{
			//Application.LoadLevel(3);
			Debug.Log ("No");
			level = 5;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. Judaism")) 
		{
			//Application.LoadLevel(4);
			Debug.Log("No");
			level = 5;
		}
	}
	
	void Level5 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 5. Who was Singapore's first Prime Minister??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. Tony Tan")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 6;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. Goh Chok Tong")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 6;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. Lee Kuan Yew")) 
		{
			//Application.LoadLevel(3);
			NumOfCorrect += 1;
			level = 6;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. Ong Teng Cheongi")) 
		{
			//Application.LoadLevel(4);
			Debug.Log("No");
			level = 6;
		}
	}
	
	void Level6 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 6. Who is the current Prime Minister??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. Tony Tan")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 7;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. Goh Chok Tong")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 7;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. Lee Kuan Yew")) 
		{
			//Application.LoadLevel(3);
			Debug.Log("No");
			level = 7;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. Lee Hsien Loong")) 
		{
			//Application.LoadLevel(4);
			NumOfCorrect += 1;
			level = 7;
		}
	}
	
	void Level7 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 7. 3 Main Races in Singapore??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. Cacasian, Chinese, Malay")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 8;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. Malay, Indian, Cacasian")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 8;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. Chinese, Malay, Korean")) 
		{
			//Application.LoadLevel(3);
			Debug.Log("No");
			level = 8;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. Chinese, Malay, Indian")) 
		{
			//Application.LoadLevel(4);
			NumOfCorrect += 1;
			level = 8;
		}
	}
	
	void Level8 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 8. When is the National Day of Singapore??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. 29th April")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 9;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. 23rd March")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 9;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. 9th August")) 
		{
			//Application.LoadLevel(3);
			NumOfCorrect += 1;
			level = 9;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. 8th August")) 
		{
			//Application.LoadLevel(4);
			Debug.Log("No");
			level = 9;
		}
	}
	
	void Level9 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 9. How old will Singapore be in 2019??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. 50")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 10;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. 54")) 
		{
			//Application.LoadLevel(2);
			NumOfCorrect += 1;
			level = 10;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. 55")) 
		{
			//Application.LoadLevel(3);
			Debug.Log("No");
			level = 10;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. 53")) 
		{
			//Application.LoadLevel(4);
			Debug.Log("No");
			level = 10;
		}
	}
	
	void Level10 ()
	{
		// Make a background box
		GUI.Box(new Rect(10,10,380,150), "Question 10. What is Singapore's national language??");
		
		// Make the First button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,220,20), "A. English")) 
		{
			//Application.LoadLevel(1);
			Debug.Log("No");
			level = 11;
		}
		
		// Make the sSecond button.
		if(GUI.Button(new Rect(20,70,220,20), "B. Mandarin")) 
		{
			//Application.LoadLevel(2);
			Debug.Log("No");
			level = 11;
		}
		
		// Make the Third button.
		if(GUI.Button(new Rect(20,100,220,20), "C. Tamil")) 
		{
			//Application.LoadLevel(3);
			Debug.Log("No");
			level = 11;
		}
		
		// Make the Forth button.
		if(GUI.Button(new Rect(20,130,220,20), "D. Malay")) 
		{
			//Application.LoadLevel(4);
			NumOfCorrect += 1;
			level = 11;
		}
	}
	
	void End ()
	{
		GUI.Box(new Rect(10,10,380,150), "END OF THE GAME! \n\n YOUR SCORE IS " + NumOfCorrect );
	}
	
	void OnGUI () 
	{	
		if (timer > 0)
		{
			GUI.Box(new Rect(310,130,70,20), "Timer : " + (int) timer);
			
			if (level == 1)
				Level1();
			else if (level == 2)
				Level2();
			else if (level == 3)
				Level3();
			else if (level == 4)
				Level4();
			else if (level == 5)
				Level5();
			else if (level == 6)
				Level6();
			else if (level == 7)
				Level7();
			else if (level == 8)
				Level8();
			else if (level == 9)
				Level9();
			else if (level == 10)
				Level10();
			else
				End ();
		}
		else
			End ();
	}	
	//	// Use this for initialization
	//	void Start () {
	//
	//	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		
		if (Input.touchCount > 0)
		{
			if (this.GetComponent<GUITexture>().HitTest(Input.GetTouch(0).position))
			{
				//Debug.Log("touched");
			}
		}
		//		int nbTouches = Input.touchCount;
		//		
		//		if(nbTouches > 0)
		//		{
		//			for (int i = 0; i < nbTouches; i++)
		//			{
		//				Touch touch = Input.GetTouch(i);
		//				
		//				if(touch.phase == TouchPhase.Began)
		//				{
		//					Ray screenRay = Camera.main.ScreenPointToRay(touch.position);
		//					
		//					RaycastHit hit;
		//					if (Physics.Raycast(screenRay, out hit))
		//					{
		//						print("User tapped on game object " + hit.collider.gameObject.name);
		//						handleTap(hit.collider.gameObject);
		//					}
		//				}
		//			}
		//		}
	}
}