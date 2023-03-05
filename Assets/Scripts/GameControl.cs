using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    public static GameControl Instance { get; private set; }
    private PlayerControls playerControls;
    [SerializeField] GameObject cutScene;
    [SerializeField] GameObject catUIPrefab;
    [SerializeField] GameObject catUIGroup;

    private void Awake() {
        Instance = this;
    }

    private void Start() {
        playerControls = new PlayerControls();
        playerControls.CutSceneControl.Enable();
        playerControls.Test.Enable();
    }

    private void Update() {
        if (cutScene.activeSelf) {
            if (playerControls.CutSceneControl.CutSceneEnd.ReadValue<float>() != 0) {
                cutScene.SetActive(false);
            }
        }
    }

    public bool GetIfInCutScene() {
        return cutScene.activeSelf;
    }

    public void KittenCollected() {
        GameObject kitten = Instantiate(catUIPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        kitten.transform.SetParent(catUIGroup.transform);
        kitten.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
