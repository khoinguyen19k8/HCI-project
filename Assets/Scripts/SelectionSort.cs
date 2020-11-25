using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectionSort : MonoBehaviour {

	static int c = 0;
	Animator anim;
	public Text canvasText;
	public AudioSource audioGood, audioBad;

	public float totalTime = 3f;
	private bool isLookedAt;
	private float timeDuration = 0f;

	// Use this for initialization
	void Start () {
		c = 0;
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isLookedAt)
		{
			int c_old = c;
			timeDuration += Time.deltaTime;
			if (timeDuration > totalTime)
			{
				timeDuration = 0;
				switch (c)
				{
					case 0:
						if (gameObject.name == "ball1")
						{
							if (anim != null)
								anim.enabled = true;
							canvasText.text = "Great. Now continue till no balls are left.";
							++c;
						}
						break;
					case 1:
						if (gameObject.name == "ball2")
						{
							if (anim != null)
								anim.enabled = true;
							++c;
						}
						break;
					case 2:
						if (gameObject.name == "ball3")
						{
							if (anim != null)
								anim.enabled = true;
							++c;
						}
						break;
					case 3:
						if (gameObject.name == "ball4")
						{
							if (anim != null)
								anim.enabled = true;
							++c;
						}
						break;
					case 4:
						if (gameObject.name == "ball5")
						{
							if (anim != null)
								anim.enabled = true;
							++c;
						}
						break;
					case 5:
						if (gameObject.name == "ball6")
						{
							if (anim != null)
								anim.enabled = true;
							++c;
						}
						break;
					case 6:
						if (gameObject.name == "ball7")
						{
							if (anim != null)
								anim.enabled = true;
							++c;
						}
						break;
					case 7:
						if (gameObject.name == "ball8")
						{
							if (anim != null)
								anim.enabled = true;
							canvasText.text = "Awesome, you sorted it all\nClick on the button on Eliza head to get to home screen or the reset button to play again.";
							++c;
						}
						break;
				
				}
				if (gameObject.tag == "Respawn")
				{
					SceneManager.LoadScene(1, LoadSceneMode.Single);
				}
				if (gameObject.tag == "DefaultScene")
				{
					SceneManager.LoadScene(0, LoadSceneMode.Single);
				}
				if (c_old == c)
				{
					audioBad.Play();
				}
				else
				{
					audioGood.Play();
				}
			}
		}
		else
		{
			timeDuration = 0;
		}
	}
	public void SetGazedAt(bool gazedAt)
	{
		isLookedAt = gazedAt;
		return;
	}
}