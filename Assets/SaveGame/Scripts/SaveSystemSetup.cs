﻿using UnityEngine;

public class SaveSystemSetup : MonoBehaviour
{

  [SerializeField] private string fileName = "Save.bin"; // file to save with the specified resolution
  [SerializeField] private bool dontDestroyOnLoad; // the object will move from one scene to another (you only need to add it once)

  void Awake()
  {
    SaveSystem.Initialize(this.fileName);
    if (this.dontDestroyOnLoad) DontDestroyOnLoad(this.transform.gameObject);
  }

  // if the object is present in all game scenes, auto save before exiting
  // on some platforms there may not be an exit function, see the Unity help
  void OnApplicationQuit()
  {
    SaveSystem.SaveToDisk();
  }
}
