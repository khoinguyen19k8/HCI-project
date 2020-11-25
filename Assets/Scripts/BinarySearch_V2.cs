using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BinarySearch_V2 : MonoBehaviour {


	static int step = 0;
	public Text canvasText;
	Animator anim;
	public GameObject[] balls1;
	public AudioSource audioGood, audioBad;

	public float totalTime = 3f;
	private bool isLookedAt;
	private float timeDuration = 0f;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		int c_old = step;
		if (isLookedAt)
		{
			timeDuration += Time.deltaTime;
			if (timeDuration > totalTime)
			{
				timeDuration = 0;
				switch (step)
				{
					case 0:
						if (gameObject.name == "ball5")
						{
							canvasText.text = "Nice. \nSince 2 is less than 5, lets select left sub half\nSelect middle ball from left half.";
							if (anim != null)
								anim.enabled = true;
							++step;
						}
						break;
					case 1:
						if (gameObject.name == "ball3")
						{
							canvasText.text = "Great.\n2 is less than 3, lets select remaining left half.\nSelect middle element from array.";
							if (anim != null)
								anim.enabled = true;
							++step;
						}
						break;
					case 2:
						if (gameObject.name == "ball2")
						{
							canvasText.text = "Awesome.\n You found the ball2.\n That wraps up your binary search\nSelect the button on the head of Eliza to return to main menu, or the reset button to play again.";
							if (anim != null)
							{
								anim.enabled = true;
							}
							++step;
						}
						break;
				}
				if (gameObject.tag == "Respawn")
				{
					SceneManager.LoadScene(1, LoadSceneMode.Single);
				}

				if (step == c_old)
				{
					audioBad.Play();
				}
				else
				{
					audioGood.Play();
					foreach (GameObject g in balls1)
						g.SetActive(false);
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
	/*public void selected(){ 
		int c_old = step;
		if (isLookedAt)
		{
			timeDuration += Time.deltaTime;
			if (timeDuration > totalTime)
			{
				timeDuration = 0;
				switch (step)
				{
					case 0:
						if (gameObject.name == "ball5")
						{
							canvasText.text = "Nice. \nSince 2 is less than 5, lets select left sub half\nSelect middle ball from left half.";
							if (anim != null)
								anim.enabled = true;
							++step;
						}
						break;
					case 1:
						if (gameObject.name == "ball3")
						{
							canvasText.text = "Great.\n2 is less than 3, lets select remaining left half.\nSelect middle element from array.";
							if (anim != null)
								anim.enabled = true;
							++step;
						}
						break;
					case 2:
						if (gameObject.name == "ball2")
						{
							canvasText.text = "Awesome.\n You found the ball2.\n That wraps up your binary search\nSelect any balloon to return to main screen.";
							if (anim != null)
							{
								anim.enabled = true;
							}
							++step;
						}
						break;
				}
				if (gameObject.tag == "Respawn")
				{
					SceneManager.LoadScene(0, LoadSceneMode.Single);
				}

				if (step == c_old)
				{
					audioBad.Play();
				}
				else
				{
					audioGood.Play();
					foreach (GameObject g in balls1)
						Destroy(g);
				}
			}
		}
		else
		{
			timeDuration = 0;
		}
	}*/
}
