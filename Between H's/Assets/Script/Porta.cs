using UnityEngine;
using System.Collections;

public class Porta : MonoBehaviour 
{
	//public int ia_god;
	int fechada_porta;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		fechada_porta = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_manager>().porta;

		if (fechada_porta == 10){
			Debug.Log("Abriu");
			Destroy(gameObject);
		}
	}
}
