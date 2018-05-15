using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	// Use this for initialization

	public Text log;
	public int wakeness = 0;
	public int negativeCount = 0;
	public int positiveCount = 0;

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
			
			else if (wakeness >= 10) {
				log.text += "\nVICTORY!";
				yield return new WaitForSecondsRealtime(1);
				log.text += "\nYou slowly rise from your bed";
				yield return new WaitForSecondsRealtime(1);
				log.text += "\nPrepare for teeth brushing";

				StartCoroutine("brushing");
			}
			
			else {
				i--;
			}
		}
	}

	IEnumerator brushing()
	{
		log.text += "\nYou brush your teeth furiously";
		yield return new WaitForSecondsRealtime(1);
		
		for (int i = 0; i <= 10; i++)
		{
			log.text += "\n...";
			yield return new WaitForSecondsRealtime(1);
			log.text += "\nThe brush goes tskhtskhtskh";
			yield return new WaitForSecondsRealtime(1);
			log.text += "\n...";
			yield return new WaitForSecondsRealtime(1);

			int toothroll = Random.Range(0, 10);
			if (toothroll >= 9)
			{
				negativeCount += 1;
				log.text += "\nYou brush too hard and chip your tooth";
				yield return new WaitForSecondsRealtime(1);
			}
			else if (toothroll <= 8)
			{
				positiveCount += 1;
				log.text += "\nYou brush with superb skill";
				yield return new WaitForSecondsRealtime(1);
			}

			if (positiveCount >= 10)
			{
				log.text += "\nYour teeth are now sparkling clean.";
				yield return new WaitForSecondsRealtime(1);

				for (int a = 0; a <= 10; a++)
				{
					log.text += ".";
					yield return new WaitForSecondsRealtime(1);
				}

				log.text += "\nINITIATE COMMUTING";
			}
			
			if (negativeCount >= 10)
			{
				log.text += "\nYou chip too many teeth and die from shame";
				yield return new WaitForSecondsRealtime(1);
				log.text += "\nGame over, dumbo";
				yield return new WaitForSecondsRealtime(5);
				Application.Quit();
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