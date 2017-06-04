using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRGame 
{
	public class DevCamera : MonoBehaviour 
	{
		private void Start () 
		{
			if (FindObjectsOfType<AudioListener>().Length > 1) {
				this.GetComponent<AudioListener>().enabled = false;
			}
		}
	}
}
