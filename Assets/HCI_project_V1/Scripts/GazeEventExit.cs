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

    public void SetGazedAt(bool gazedAt)
    {
        print(gazedAt);
        isLookedAt = gazedAt;
        return;
    }
    void Start()
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