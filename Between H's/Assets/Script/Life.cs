using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour 
{
	public int vida_life;
	int vida;
	void Start () 
	{
	
	}
	
	void Update () 
	{
		vida = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_manager>().vidinha;
		if (vida <= 2 && vida_life == 3)
		{
			renderer.enabled = false;
		}
		if (vida <= 1 && vida_life == 2)
		{
			renderer.enabled = false;
		}
		if (vida <= 0 && vida_life == 1)
		{
			Application.LoadLevel("Game_Over");
			renderer.enabled = false;
		}

	}
}
