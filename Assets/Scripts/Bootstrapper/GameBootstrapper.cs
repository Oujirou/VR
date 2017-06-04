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
			LoadGameScene();
		}

		private void LoadGameScene ()
		{
			SceneManager.LoadScene(GameScenes.GAME_SCENE, LoadSceneMode.Additive);
			Debug.LogFormat("<color=lime>[{0}]</color> Loaded scene {1}.", this.GetType().Name, GameScenes.GAME_SCENE);
		}
	}

}
