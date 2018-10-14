using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour {


	public void LoadScene(int level){
		//Application.LoadLevel (level);
		SceneManager.LoadScene(level);
		print ("pressed");
	}
	// Use this for initialization
	void Start () {
		print ("press start");
	}
	
	// Update is called once per frame
	void Update () {
		//print ("press update");
	}
}


