using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GazeEventOpen : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt;
    private float timeDuration = 0f;
    public GameObject openObject;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    private Renderer myRenderer;
    //public GameObject canvasManager;
    //private GameObject canvas;

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            myRenderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
    }
    void Start()
    {
        //canvasTransform = canvasManager.GetComponent<Transform>();
        //canvas = canvasManager.transform.Find("MessageCanvas").gameObject;
        myRenderer = GetComponent<Renderer>();
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
                //canvas.SetActive(true);
                openObject.SetActive(true);
            }
        }
        else
        {
            timeDuration = 0;
        }

    }
}