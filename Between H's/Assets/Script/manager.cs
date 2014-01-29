using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour 
{
	bool cima = false;
	bool baixo = true;
	public AudioClip music;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.UpArrow) && cima) 
		{
			transform.Translate(0, 4f, 0 * Time.deltaTime);
			baixo = true;
			cima = false;
		}
		if(Input.GetKeyDown(KeyCode.Space) && baixo)
		{
			Application.LoadLevel ("Historia");
			audio.Play();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow) && baixo) 
		{
			transform.Translate(0, -4f, 0 * Time.deltaTime);
			cima = true;
			baixo = false;
		}
		if(Input.GetKeyDown(KeyCode.Space) && cima)
		{
			audio.Play();
			Application.LoadLevel ("Creditos");
		}
	}
}
