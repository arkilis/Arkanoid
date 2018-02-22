using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float speed = 100.0f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed;	
	}


	void OnCollisionEnter2D(Collision2D col) {

		if (col.gameObject.name == "Racket") {
			// play hit music
			FindObjectOfType<AudioManager>().Play("hitRacket");
			Vector2 newDirection = new Vector2 (HitFactor (transform.position, col.transform.position, col.collider.bounds.size.x), 1).normalized;
			GetComponent<Rigidbody2D>().velocity = newDirection * speed;
		}


		if (col.gameObject.name == "border_bottom") {
			FindObjectOfType<GameManager> ().GameStop ();
		}
	}


	float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) {
		return (ballPos.x - racketPos.x) / racketWidth;
	}
}
