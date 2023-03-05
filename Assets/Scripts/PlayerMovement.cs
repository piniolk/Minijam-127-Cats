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
        if (!GameControl.Instance.GetIfInCutScene()) {
            Vector2 movement = playerControls.PlayerControl.Walk.ReadValue<Vector2>();

            Vector3 vector3 = transform.position;
            vector3.x += movement.x;
            vector3.y += movement.y;

            if (Physics2D.Raycast(vector3, Vector3.back).collider != null) {
                if (Physics2D.Raycast(vector3, Vector3.back).collider.gameObject.tag == "Walkable") {
                    rigidbody.transform.Translate(movement * Time.deltaTime * movementSpeed);
                }
            }
        }
    }
}
