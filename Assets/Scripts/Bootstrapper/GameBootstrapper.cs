using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRGame 
{

	public class GameBootstrapper : MonoBehaviour 
	{
		private void Start () 
		{
            SceneManager.LoadScene(GameScenes.GAME_SCENE, LoadSceneMode.Additive);
			Debug.LogFormat("[{0}]: Loaded scene{1}.", this.GetType().Name, GameScenes.GAME_SCENE);
		}
	}

}
