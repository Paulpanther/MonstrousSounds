using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementController : MonoBehaviour {

    public float playerSpeed = 10;
    public float screamHearDistance;

    void Update()
    {
        bool isSpacePressed = Input.GetButton("Jump");
        if (isSpacePressed)
        {
            ViewSizeScript.setToScreaming();
            Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, screamHearDistance);
            foreach (Collider2D hit in hits)
            {
                if (hit.CompareTag("Scientist"))
                {
                    Debug.Log("A Scientist heard that...");
                    //hit.GetComponent<INSERTSCRIPTNAMEHERE>().INSERTMETHODNAMEHERE(transform.position);
                }
            }
        }
    }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if(moveVertical != 0 || moveHorizontal != 0)
        {
            ViewSizeScript.setToWalking();
        }
        else
        {
            ViewSizeScript.setToStanding();
        }
        transform.Translate(moveHorizontal * playerSpeed, moveVertical * playerSpeed, 0);
    }
}
