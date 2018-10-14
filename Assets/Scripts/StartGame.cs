using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {


	public void LoadScene(int level){
		Application.LoadLevel (level);
	}
	// Use this for initialization
	void Start () {
		print ("press");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
