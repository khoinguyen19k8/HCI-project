using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GazeEventExit : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt = false;
    private float timeDuration = 0f;

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
    }
    void Start()
    {
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
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
                //Application.Quit();
            }
        }
        else
        {
            timeDuration = 0;   
        }

    }
}