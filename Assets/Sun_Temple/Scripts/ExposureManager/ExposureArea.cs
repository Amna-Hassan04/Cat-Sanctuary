﻿/// <summary>
/// This script goes on trigger area. When player enters/exits trigger sun intensity will be adjusted according to ExposureManager
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


namespace SunTemple
{
	public class ExposureArea : MonoBehaviour
    {
		private bool scriptIsEnabled = false;


		void Start(){
			if (ExposureManager.instance) {
				scriptIsEnabled = true;
			} else {
				Debug.LogWarning (this.GetType ().Name + ".cs on " + gameObject.name + ": " + "You have exposureArea in scene, but no ExposureManager", gameObject);
				scriptIsEnabled = false;
			}
		}




        void OnTriggerEnter(Collider other)
        {
			if (scriptIsEnabled) {
				if (other.tag == ExposureManager.instance.PlayerTag)
					ExposureManager.instance.SetSunIntensityToInterior();
				//	ExposureManager.instance.UpdateAudioZone();
			}

        }

        void OnTriggerExit(Collider other)
        {
			if (scriptIsEnabled) {
				if (other.tag == ExposureManager.instance.PlayerTag)
					ExposureManager.instance.SetSunIntensityToExterior();
					//ExposureManager.instance.UpdateAudioZone();


			}


        }

    }
}
