using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class GazeEventReset_V2 : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt;
    private float timeDuration = 0f;
    
    //public GameObject resetObject;
    //public Text resetText;
    //private Transform children;

    //public Material inactiveMaterial;
    //public Material gazedAtMaterial;

    //private Renderer myRenderer;

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
        //if (inactiveMaterial != null && gazedAtMaterial != null)
        //{
            //myRenderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        //}
    }
    void Start()
    {
        //children = resetObject.GetComponent<Transform>();
        //myRenderer = GetComponent<Renderer>();
        SetGazedAt(false);
    }
    void OnEnable()
    {
        SetGazedAt(false);
    }
    void Update()
    {
        if (isLookedAt)
        {
            timeDuration += Time.deltaTime;
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