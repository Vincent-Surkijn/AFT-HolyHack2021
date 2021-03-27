using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class RefTracking : MonoBehaviour
{
    private ARTrackedImageManager aRTrackedImageManager;
    public GameObject Info;

    
    private void Awake()
    {
        aRTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        aRTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        Info.GetComponent<Text>().text = "Camera is calibrated. Keep it like this.";
        Invoke(nameof(RemoveInfo), 5);
        foreach(var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }

    public void RemoveInfo() {
        Info.gameObject.SetActive(false);
    }

}
