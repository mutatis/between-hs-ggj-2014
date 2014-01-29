using UnityEngine;
using System.Collections;

public class god : MonoBehaviour 
{
	public int ia_god;
	int god_game;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		god_game = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_manager>().ceu;
		if (god_game >= 1 && ia_god == 4) 
		{
			renderer.enabled = true;
		} 
		if(god_game <= 2 && ia_god == 4) 
		{
			renderer.enabled = false;
		}
		if (god_game >= 3 && ia_god == 3) 
		{
			renderer.enabled = true;
		}
		if(god_game <= 4 && ia_god == 3) 
		{
			renderer.enabled = false;
		}
		if (god_game >= 5 && ia_god == 2) 
		{
			renderer.enabled = true;
		}
		if(god_game <= 6 && ia_god == 2)
		{
			renderer.enabled = false;
		}
		if (god_game >= 7 && ia_god == 1) 
		{
			renderer.enabled = true;
		}
		if(god_game <= 8 && ia_god == 1)
		{
			renderer.enabled = false;
		}
	}
}
