using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementController : MonoBehaviour {

    public float playerSpeed = 10;

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.Translate(moveHorizontal * playerSpeed, moveVertical * playerSpeed, 0);
    }
}
