using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ReturnToMenu : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt;
    private float timeDuration = 0f;
    public GameObject[] closeObjects;
    public GameObject[] openObjects;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    private Renderer myRenderer;

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            myRenderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
        return;
    }
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
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
                foreach (GameObject g in closeObjects)
                    g.SetActive(false);
                foreach (GameObject g in openObjects)
                    g.SetActive(true);
            }
        }
        else
        {
            timeDuration = 0;
        }

    }
}