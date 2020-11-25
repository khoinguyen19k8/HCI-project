using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour {

	float Speed = 10;
	public Text commandText;
	static int c = 0;
	public AudioSource audioGood, audioBad;

	// Use this for initialization
	void Start () {
		c = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 5 * Time.deltaTime * Speed, 0);
		if (Input.GetButtonDown("Fire2") == true) //apple
		{
			if (c == 0)
			{
				commandText.text = "a = \"apple\" < \"banana\";\nfruit = a ? \"strawberry\" : \"apple\";\nWhat is the value of fruit?";
				audioGood.Play();
				++c;
			}
			else
				audioBad.Play();
		}
		else if (Input.GetButtonDown("Fire3") == true) //strawberry
		{
			if (c == 1)
			{
				commandText.text = "a = (5 > 1) && (10 > 2) && (2 > 3);\n if(a == true) {print(\"apple\") else {print(\"banana\")}}";
				audioGood.Play();
				++c;
			}
			else
				audioBad.Play();
		}
		else if (Input.GetButtonDown("Jump") == true) //banana
		{
			if (c == 2)
			{
				commandText.text = "Congratulation, and always remember an apple a day keeps the doctor away. You can now exit or reset the level";
				audioGood.Play();
			}
			else
				audioBad.Play();
		}
	}

	public void stopRotation(){
		Speed = 0;
	}

	public void resumeRotation(){
		Speed = 10;
	}

	/*public void selected(){
		if (gameObject.name == "Apple") {
			audioGood.Play ();
			Destroy (gameObject);
			commandText.text = "Congrats. \nAn apple a day keeps doctor away.\n" +
			"if (fruit == Banana) { Go Back };";
			c = 1;
		} else if (gameObject.name == "Banana" && c == 1) {
			SceneManager.LoadScene (0, LoadSceneMode.Single);
		} else {
			audioBad.Play ();
		}
	}*/
}
