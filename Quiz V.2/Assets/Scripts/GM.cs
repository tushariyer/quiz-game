using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	public Question[] questions;
	private static List<Question> unseenQs;
	private Question currentQ;

	[SerializeField]
	private Text factText;

	[SerializeField]
	private Text trueText;

	[SerializeField]
	private Text falseText;

	[SerializeField]
	private float replayDelay = 2f;

	void Start(){
		if (unseenQs == null || unseenQs.Count == 0) {
			unseenQs = questions.ToList<Question> ();
		}

		SetCurQ ();
	}

	void SetCurQ(){
		int randIndex = Random.Range (0, unseenQs.Count);
		currentQ = unseenQs [randIndex];

		factText.text = currentQ.fact;

		if (currentQ.isTrue) {
			trueText.text = "Correct";
			falseText.text = "Incorrect";
		} else {
			trueText.text = "Incorrect";
			falseText.text = "Correct";
		}
	}

	IEnumerator SelectNextQ(){
		unseenQs.Remove(currentQ);

		yield return new WaitForSeconds (replayDelay);

		if (unseenQs == null || unseenQs.Count == 0) {
			SceneManager.LoadScene ("Replay");
		} else {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void ClickTrue(){
		if (currentQ.isTrue) {
			factText.text = "Correct!";
		} else {
			factText.text = "Incorrect!";
		}

		StartCoroutine (SelectNextQ ());
	}

	public void ClickFalse(){
		if (!currentQ.isTrue) {
			factText.text = "Correct!";
		} else {
			factText.text = "Incorrect!";
		}

		StartCoroutine (SelectNextQ ());
	}
}
//Tushar Iyer