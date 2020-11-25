using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class LevelSelection : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt;
    private float timeDuration = 0f;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    private Text levelChoice;

    private Image buttonImage;

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            buttonImage.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
        return;
    }
    void OnEnable()
    {
        buttonImage = GetComponent<Image>();
        SetGazedAt(false);
    }
    void Start()
    {
        levelChoice = GetComponentInChildren<Text>();
        SetGazedAt(false);
    }
    void Update()
    {
        timeDuration += Time.deltaTime;
        if (isLookedAt)
        {
            if (timeDuration > totalTime)
            {
                timeDuration = 0;
                if (levelChoice.text == "Level 1")
                {
                    SceneManager.LoadScene(1, LoadSceneMode.Single);
                }
                else if (levelChoice.text == "Level 2")
                {
                    SceneManager.LoadScene(2, LoadSceneMode.Single);
                }
                else if (levelChoice.text == "Level 3")
                {
                    SceneManager.LoadScene(3, LoadSceneMode.Single);
                }
            }
        }
        else
        {
            timeDuration = 0;
        }

    }
}