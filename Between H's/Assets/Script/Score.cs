using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	
	public int n_do_ponto;
	int score_game;
	
	void Start () 
	{
		
	}
	
	void Update () {

		score_game = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_manager>().ponto;

		if (score_game >= 1 && n_do_ponto == 1) {
			renderer.enabled = true;
		}
		if (score_game >= 2 && n_do_ponto == 2) {
			renderer.enabled = true;
		}
		if (score_game >= 3 && n_do_ponto == 3) {
			renderer.enabled = true;
		}
		if (score_game >= 4 && n_do_ponto == 4) {
			renderer.enabled = true;
		}
		if (score_game >= 5 && n_do_ponto == 5) {
			renderer.enabled = true;
		}
		if (score_game >= 6 && n_do_ponto == 6) {
			renderer.enabled = true;
		}
		if (score_game >= 7 && n_do_ponto == 7) {
			renderer.enabled = true;
		}
		if (score_game >= 8 && n_do_ponto == 8) {
			renderer.enabled = true;
		}
		if (score_game >= 9 && n_do_ponto == 9) {
			renderer.enabled = true;
		}
		if (score_game >= 10 && n_do_ponto == 10) {
			renderer.enabled = true;
		}

	}
}
