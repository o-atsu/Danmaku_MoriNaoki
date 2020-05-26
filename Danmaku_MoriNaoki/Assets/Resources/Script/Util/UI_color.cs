﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_color : MonoBehaviour
{
    [SerializeField]
	private Color day;
    [SerializeField]
	private Color night;

	static string[] A_B_C = new string[]{"Zone_A", "Zone_B", "Zone_C"};
	static string[] D_E = new string[]{"Zone_D", "Zone_E"};

	void Color_change(){
		string sname = SceneManager.GetActiveScene().name;

		foreach(string i in A_B_C){
			if(sname.Equals(i)){
				if(GetComponent<Image>()) GetComponent<Image>().color = day;
				else if(GetComponent<Text>()) GetComponent<Text>().color = day;
			}
		}

		foreach(string i in D_E){
			if(sname.Equals(i)){
				if(GetComponent<Image>()) GetComponent<Image>().color = night;
				else if(GetComponent<Text>()) GetComponent<Text>().color = night;
			}
		}
	}

	void Start(){
		Color_change();
		SceneManager.sceneLoaded += SceneLoaded;
	}

	void SceneLoaded(Scene nextScene, LoadSceneMode mode){
		Color_change();
	}
}
