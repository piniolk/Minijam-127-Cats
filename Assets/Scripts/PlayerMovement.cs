using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour {

    private PlayerControls playerControls;
    private float movementSpeed = 5f;

    private Rigidbody2D rigidbody;

    private void Awake() {
        this.rigidbody = gameObject.GetComponent<Rigidbody2D>();
        this.playerControls = new PlayerControls();
        playerControls.PlayerControl.Enable();
    }

    private void Update() {
        Vector2 movement = playerControls.PlayerControl.Walk.ReadValue<Vector2>();
        rigidbody.transform.Translate(movement * Time.deltaTime * movementSpeed);
    }

    public void WalkL() {
        Debug.Log("Walk left");
    }



}
