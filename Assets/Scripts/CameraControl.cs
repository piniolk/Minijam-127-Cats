using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    [SerializeField] GameObject[] cameraArrays;
    [SerializeField] Transform playerLocation;
    private GameObject closestCamera;
    private GameObject currentActiveCamera;

    private void Start() {
        closestCamera = GetClosestCamera();
        closestCamera.SetActive(true);
        currentActiveCamera = closestCamera;
    }

    // Update is called once per frame
    void Update() {
        Vector3 currentCamPos = currentActiveCamera.transform.position;
        currentCamPos.z = playerLocation.position.z;
        if (Mathf.Abs(Vector3.Distance(playerLocation.position, currentCamPos)) > 5) {
            if (this.closestCamera != GetClosestCamera()) {
                closestCamera = GetClosestCamera();
                UpdateCamera();
            }
        }
    }

    private void UpdateCamera() {
        this.closestCamera.SetActive(true);
        currentActiveCamera.SetActive(false);
        currentActiveCamera = closestCamera;
        Debug.Log("Function");
    }

    private GameObject GetClosestCamera() {
        GameObject closestCamera = cameraArrays[0];
        Vector3 closestCameraLoc = closestCamera.transform.position;
        foreach (GameObject camera in cameraArrays) {
            if(Mathf.Abs(Vector3.Distance(playerLocation.position, camera.transform.position)) < Mathf.Abs(Vector3.Distance(playerLocation.position, closestCameraLoc))) {
                closestCamera = camera;
                closestCameraLoc = camera.transform.position;
            }
        }
        return closestCamera;
    }
}
