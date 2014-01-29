using UnityEngine;
using System.Collections;

public class Setinha : MonoBehaviour {

	bool direita = false;
	bool esquerda = true;
	public AudioClip music;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftArrow) && direita) 
		{
			transform.Translate(-6f, 0, 0 * Time.deltaTime);
			esquerda = true;
			direita = false;
		}
		if(Input.GetKeyDown(KeyCode.Space) && direita)
		{
			Application.LoadLevel ("Intro");
			audio.Play();
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) && esquerda) 
		{
			transform.Translate(6f, 0, 0 * Time.deltaTime);
			direita = true;
			esquerda = false;
		}
		if(Input.GetKeyDown(KeyCode.Space) && esquerda)
		{
			audio.Play();
			Application.LoadLevel ("Game");
		}
	}
}
