using UnityEngine;
using System.Collections;

public class hell : MonoBehaviour 
{

	public int ia_hell;
	int hell_game;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		hell_game = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_manager>().inf;
		if (hell_game >= 2 && ia_hell == 8) 
		{
			renderer.enabled = true;
		}
		if(hell_game <= 2 && ia_hell == 8)
		{
			renderer.enabled = false;
		}
		if (hell_game >= 4 && ia_hell == 7) 
		{
			renderer.enabled = true;
		}
		if(hell_game <= 4 && ia_hell == 7)
		{
			renderer.enabled = false;
		}
		if (hell_game >= 6 && ia_hell == 6) 
		{
			renderer.enabled = true;
		}
		if(hell_game <= 6 && ia_hell == 6) 
		{
			renderer.enabled = false;
		}
		if (hell_game >= 8 && ia_hell == 5) 
		{
			renderer.enabled = true;
		}
		if(hell_game <= 8 && ia_hell == 5) 
		{
			renderer.enabled = false;
		}
	}
}
