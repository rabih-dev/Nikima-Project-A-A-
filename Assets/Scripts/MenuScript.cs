﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	[SerializeField] private Button playButton;
	[SerializeField] private Animator playAnimator;

	void Start () {

	}
	
	void Update () {
		
	}

	public void PlayAnimation(){
		//playButton.interactable = false;
		playAnimator.SetTrigger("fadeOut");
	}
}
