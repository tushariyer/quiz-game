using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MCGM : MonoBehaviour {

	public MCQuestion[] questions;
	private static List<MCQuestion> unseenQs;
	private MCQuestion currentQ;

	public Text factText;
	public float resetDelay = 1;

	//public Text pointText;

	public GameObject buttonA, buttonB, buttonC, buttonD;
	//	public static int points = 0;

	// Use this for initialization
	void Start () {
		if (unseenQs == null || unseenQs.Count == 0) {
			unseenQs = questions.ToList<MCQuestion> ();
		}
		GetQuestion ();
		//pointText.text = points.ToString();
	}

	void GetQuestion(){

		int randomIndex = Random.Range (0, unseenQs.Count);
		currentQ = unseenQs [randomIndex];

		factText.text = currentQ.fact;


		buttonA.GetComponentInChildren<Text>().text = currentQ.choices[0];
		buttonB.GetComponentInChildren<Text>().text = currentQ.choices[1];
		buttonC.GetComponentInChildren<Text>().text = currentQ.choices[2];
		buttonD.GetComponentInChildren<Text>().text = currentQ.choices[3];

	}

	public void ClickA(){
		if(buttonA.GetComponentInChildren<Text>().text == currentQ.answer)
		{
			factText.text = "Correct!";
			//pointsCheck(true);
			//pointText.text = points.ToString();
		}
		else
		{
			factText.text = "Incorrect!";
		}
		Invoke ("nextQuestion", resetDelay);
		unseenQs.Remove (currentQ);
	}

	public void ClickB(){
		if(buttonB.GetComponentInChildren<Text>().text == currentQ.answer)
		{
			factText.text = "Correct!";
			//pointsCheck(true);
			//pointText.text = points.ToString();
		}
		else
		{
			factText.text = "Incorrect!";
		}
		Invoke ("nextQuestion", resetDelay);
		unseenQs.Remove (currentQ);
	}

	public void ClickC(){
		if(buttonC.GetComponentInChildren<Text>().text == currentQ.answer)
		{
			factText.text = "Correct!";
			//pointsCheck(true);
			//pointText.text = points.ToString();
		}
		else
		{
			factText.text = "Incorrect!";
		}
		Invoke ("nextQuestion", resetDelay);
		unseenQs.Remove (currentQ);
	}

	public void ClickD(){
		if(buttonD.GetComponentInChildren<Text>().text == currentQ.answer)
		{
			factText.text = "Correct!";
			//pointsCheck(true);
			//pointText.text = points.ToString();
		}
		else
		{
			factText.text = "Incorrect!";
		}
		Invoke ("nextQuestion", resetDelay);
		unseenQs.Remove (currentQ);
	}

	void nextQuestion(){
		if (unseenQs == null || unseenQs.Count == 0) {
			SceneManager.LoadScene ("Replay");
		} else {
			SceneManager.LoadScene ("MCQ");
		}
	}

	/*void pointsCheck(bool correct)
	{
		if (correct)
			points++;
		else
			points--;
	}*/
}
//Tushar Iyer