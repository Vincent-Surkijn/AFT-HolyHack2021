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
    public GameObject spawn;
    public ARSessionOrigin arOrig;
    private Vector3 refPos;
    private Quaternion refRot;

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
        //ARSessionOrigin arOrig = GameObject.FindObjectOfType<ARSessionOrigin>();
        Info.GetComponent<Text>().text = "Camera is calibrated. Keep it like this.";
        Invoke(nameof(RemoveInfo), 5);
        foreach(ARTrackedImage trackedImage in args.added)  // for each tracked image do this, but there will only be 1
        {
            refPos = trackedImage.transform.position;
            refRot = trackedImage.transform.rotation;
            // spawn first object (person?)
            spawn.SetActive(true);
            spawn.transform.SetPositionAndRotation( refPos + Vector3.left * 0.04f, refRot);  // spawn object 0.04m to left
        }
    }

    public void RemoveInfo() {
        Info.gameObject.SetActive(false);
    }

}
