//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Flips the camera output back to normal for D3D.
//
//=============================================================================

using UnityEngine;

[ExecuteInEditMode]
public class SteamVR_CameraFlip : MonoBehaviour
{
#if !UNITY_EDITOR_OSX
	void Awake()
	{
		Debug.Log("SteamVR_CameraFlip is deprecated in Unity 5.4 - REMOVING");
		DestroyImmediate(this);
	}
#endif
}

