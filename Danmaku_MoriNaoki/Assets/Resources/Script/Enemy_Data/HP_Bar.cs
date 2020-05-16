﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP_Bar : MonoBehaviour
{
	private Slider hp_bar;
	private Enemy enemy;

	void Awake(){
		hp_bar = GetComponent<Slider>();
		enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
		DontDestroyOnLoad(gameObject);
	}

	void SceneLoaded(){
		string[] destroys = new string[]{"Title", "Result"};
		string sname = SceneManager.GetActiveScene().name;
		foreach(string i in destroys){
			if(sname.Equals(i)){
				DestroyImmediate(gameObject);
			}
		}
		enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
	}

	void FixedUpdate(){
		if(enemy != null){
			hp_bar.value = enemy.Get_percent();
		}else{
			hp_bar.value = 0;
		}
	}
}
