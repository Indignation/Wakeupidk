using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	// Use this for initialization

	public Text log;
	public int wakeness = 0;

	IEnumerator wakeup()
	{
		for (int i = 0; i <= 10; i++)
		{
			log.text += "\nYou're trying to wake up";
			yield return new WaitForSecondsRealtime(1);
			log.text += "\n...";
			yield return new WaitForSecondsRealtime(1);

			int wakeuproll = Random.Range(1, 10);
			if (wakeuproll <= 4) {
				wakeness += 1;
				log.text += "\nYour wakeness has improved by 1\n...";
			}
			
			else if (wakeness == 10) {
				log.text += "\nVICTORY!";
				yield return new WaitForSecondsRealtime(1);
				log.text += "\nYou slowly rise from your bed";
				log.text += "\nPrepare for teeth brushing";
			}
			
			else {
				i--;
			}
		}
	}
	
	void Start () {
		log.text = "The game has started";
		StartCoroutine("wakeup");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}