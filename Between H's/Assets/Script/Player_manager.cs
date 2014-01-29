using UnityEngine;
using System.Collections;

public class Player_manager : MonoBehaviour {

	private int jump = 250;
	private bool grounded = false;
	public int jumpnumb = 0;
	public int ceu = 4;
	public int inf = 4;
	public int vidinha = 3;
	public int porta = 0;
	public int ponto = 0;

	[HideInInspector]
	public bool facingRight = true;
	public float maxSpeed = 5f;
	public float moveForce = 365f;

	public static Player_manager instance;
	
	void Awake()
	{
		instance = this;	
	}
	

	void Start () 
	{
		ceu = 5;
		inf = 5;
	}

	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		
		if ((Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) && jumpnumb <= 2 && grounded) 
		{
			rigidbody2D.AddForce(new Vector2(0f, jump));
			jumpnumb += 1;
		}
		if (jumpnumb >= 2) 
		{
			jumpnumb = 0;
			grounded = false;
		}

		/*if (Input.GetKey(KeyCode.RightArrow)) 
		{
			transform.Translate (0.1f, 0, 0 * Time.deltaTime);
			Flip();
		}
		else if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.Translate (-0.1f, 0, 0 * Time.deltaTime);
			//transform.Rotate 
			Flip();
		}*/

		if (h * rigidbody2D.velocity.x < maxSpeed) {
						rigidbody2D.AddForce (Vector2.right * h * moveForce);
				}

		if (h > 0 && !facingRight) {
						Flip ();
				}

		else if (h < 0 && facingRight) {
						Flip ();
				}

	}

	void Flip ()
	{

		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Plataforma") 
		{
			inf += 1;
			ceu -= 1;
			jumpnumb = 0;
			grounded = true;
			if (ceu <= 0)
			{
				ceu = 0;
				vidinha -= 1;
			}
			if (inf >= 9) 
			{
				inf = 9;
			}
		}
		if (collision.gameObject.tag == "Plataforma_ceu") {
			inf -= 1;
			ceu += 1;
			jumpnumb = 0;
			grounded = true;
			if (ceu >= 9) {
				ceu = 9;
			}
			if (inf <= 0) {
				inf = 0;
				vidinha -= 1;
			}
		}

		if (collision.gameObject.tag == "Plataforma_neutra") {
			grounded = true;
		}
		if (collision.gameObject.tag == "porta_fechada") {
			grounded = true;
		}

		if (collision.gameObject.tag == "Finish") {
			Application.LoadLevel("Game_Over");
		}

		if (collision.gameObject.tag == "haven") {
			ceu += 2;
			inf -= 2;
			porta += 1;
			ponto += 1;
			Destroy(collision.gameObject);
				}
		if (collision.gameObject.tag == "hell") {
			ceu -= 2;
			inf += 2;
			porta += 1;
			ponto += 1;
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.tag == "porta_fechada" && porta == 10) {
			Application.LoadLevel ("You_won");
		}
}
}