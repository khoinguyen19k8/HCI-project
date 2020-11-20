using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Level4 : MonoBehaviour
{
    public float totalTime = 3f;
    private bool isLookedAt;
    private float timeDuration = 0f;
    public GameObject Menu;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    private Image buttonImage;

    public void SetGazedAt(bool gazedAt)
    {
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            buttonImage.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
    }
    void OnEnable()
    {
        buttonImage = GetComponent<Image>();
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
            }
        }
        else
        {
            timeDuration = 0;
        }

    }
}