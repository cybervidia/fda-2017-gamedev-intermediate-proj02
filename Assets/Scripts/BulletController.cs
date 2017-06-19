﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	// La velocità del proiettile
	public float speed = 30f;

	void Update () {
		// Ad ogni update sposto il proiettile verso l'alto (asse z)
		// basandomi sul deltaTime
		float x = Random.Range(-20,20);
		transform.Translate(x * Time.deltaTime, 0, speed * Time.deltaTime);	
	}

	// Quando il renderer dell'oggetto esce dalla vista della
	// Camera, l'oggetto viene reso invisibile
	void OnBecameInvisible() {
		gameObject.SetActive (false);
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Hit: " + collision.gameObject);
	}
}
