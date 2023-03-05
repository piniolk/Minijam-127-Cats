using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControl : MonoBehaviour {
    public static GameControl Instance { get; private set; }
    private PlayerControls playerControls;
    [SerializeField] GameObject[] cutScene;
    [SerializeField] GameObject endGameScene;
    [SerializeField] GameObject[] endGameSceneText;
    [SerializeField] GameObject catUIPrefab;
    [SerializeField] GameObject catUIGroup;
    [SerializeField] TextMeshProUGUI timerText;
    private float cutsceneTimer = 1f;
    private float gameTimer = 70f;
    private int currentCutScene = 0;
    private int totalKittens;
    private bool isInCutScene;

    private void Awake() {
        Instance = this;
    }

    private void Start() {
        playerControls = new PlayerControls();
        playerControls.CutSceneControl.Enable();
        playerControls.Test.Enable();
        isInCutScene = true;
        TotalKittens();
    }

    private void Update() {
        if (cutScene[currentCutScene].activeSelf) {
            if (cutsceneTimer <= 0) {
                if (playerControls.CutSceneControl.CutSceneEnd.ReadValue<float>() != 0) {
                    //cutScene.SetActive(false);
                    NextCutScene();
                }
            }
            cutsceneTimer -= Time.deltaTime;
        } else {
            if (gameTimer > 0) {
                gameTimer -= Time.deltaTime;
                timerText.text = gameTimer.ToString("#.0");
            }
        }
        if (gameTimer <= 0) {
            gameTimer = 0;
            timerText.text = "0";
            EndGame();
        }
    }

    public bool GetIfInCutScene() {
        return isInCutScene;
    }

    public void NextCutScene() {
        cutsceneTimer = 1f;
        cutScene[currentCutScene].SetActive(false);
        int nextCutScene = currentCutScene + 1;
        if (nextCutScene < cutScene.Length) {
            currentCutScene++;
            cutScene[currentCutScene].SetActive(true);
        } else {
            isInCutScene = false;
        }
    }

    private void TotalKittens() {
        this.totalKittens = (GameObject.FindGameObjectsWithTag("Kitten")).Length;
    }

    public void KittenCollected() {
        GameObject kitten = Instantiate(catUIPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        kitten.transform.SetParent(catUIGroup.transform);
        kitten.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void EndGame() {
        endGameScene.SetActive(true);
        if ((GameObject.FindGameObjectsWithTag("Kitten")).Length == 0) {
            endGameSceneText[0].SetActive(true);
        } else if ((GameObject.FindGameObjectsWithTag("Kitten")).Length == totalKittens) {
            endGameSceneText[2].SetActive(true);
        } else {
            endGameSceneText[1].SetActive(true);
        }
        isInCutScene = true;
    }
}
