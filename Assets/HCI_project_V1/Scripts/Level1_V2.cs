using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Level1_V2 : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt;
    private float timeDuration = 0f;
    //public GameObject[] closeObjects;
    //public GameObject[] openObjects;
    
    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    //public GameObject player;
    //private Transform playerPosition;

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
        //playerPosition = player.GetComponent<Transform>();
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
                SceneManager.LoadScene(1, LoadSceneMode.Single);

            }
        }
        else
        {
            timeDuration = 0;
        }

    }
}