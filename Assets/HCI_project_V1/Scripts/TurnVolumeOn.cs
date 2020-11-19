using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TurnVolumeOn : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt;
    private float timeDuration = 0f;
    public GameObject audioSource;

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
        return;
    }
    void OnEnable()
    {
        SetGazedAt(false);
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
                //AudioSource audioComp = audioSource.GetComponent<AudioSource>();
                //audioComp.volume = 1;
                audioSource.GetComponent<AudioSource>().volume = 1;
            }
        }
        else
        {
            timeDuration = 0;
        }

    }
}
