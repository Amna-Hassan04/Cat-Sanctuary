﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SunTemple{
	

	public class WillowWindSwaySimple : MonoBehaviour {

		public float windIntensity = 0.1f;
		public float swayFrequency = 0.5f;
		public Vector3 direction = new Vector3 (1, 0, 1);
		private float seed;

		private Vector3 initialEulerAngles;

		void Start () {
			seed = Random.Range (0.5f, 1.5f);	
			initialEulerAngles = transform.eulerAngles;
		}


		void Update () {
			float rotateFactor = Mathf.Sin (Time.time * seed * swayFrequency) * windIntensity;	

			Vector3 rot = new Vector3 (rotateFactor, initialEulerAngles.y, rotateFactor);

			transform.eulerAngles = rot;



			
		}
	}


}
