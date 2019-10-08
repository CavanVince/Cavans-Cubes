using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDestroy : MonoBehaviour {

    private GameObject Music;
    // Use this for initialization
   void Start()
    {
        Music = GameObject.FindGameObjectWithTag("Music");
        Destroy(Music);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
