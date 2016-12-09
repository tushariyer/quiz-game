using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

	public void PickMode(){
		SceneManager.LoadScene ("Choose");
	}

	public void TrueFalse(){
		SceneManager.LoadScene ("TF");
	}

	public void Choices(){
		SceneManager.LoadScene ("MCQ");
	}

	public void DoOver(){
		SceneManager.LoadScene ("Choose");
	}

	public void BurnInHell(){
		Application.Quit ();
	}
}
