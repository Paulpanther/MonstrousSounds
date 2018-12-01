using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSizeScript : MonoBehaviour {
    private enum Action { Screaming, Standing, Walking};

    private static float screamStart = 0;
    public static int screamDuration = 4;
    public static int screamCooldownSeconds = 6;
    public float transitionStep = .05f;
    private static float standingScaleFactor = 0.4f;
    private static float walkingScaleFactor = 0.6f;
    private static float screamScaleFactor = 1.4f;
    private static float currentScale;


    private static Action currentAction;

    // Use this for initialization
    void Start () {
        currentAction = Action.Standing;
        currentScale = standingScaleFactor;
    }
	
    public static void setToScreaming()
    {
        if (screamStart == 0 || screamStart +  screamDuration + screamCooldownSeconds < Time.time) {
            currentAction = Action.Screaming;
            screamStart = Time.time;
        }
    }

    public static void setToWalking()
    {
        if (currentAction != Action.Screaming)
        {
            currentAction = Action.Walking;
        }
    }

    public static void setToStanding()
    {
        if (currentAction != Action.Screaming)
        {
            currentAction = Action.Standing;
        }
    }


    // Update is called once per frame
    void Update () {
        switch (currentAction)
        {
            case Action.Screaming:
                if (screamStart + screamDuration > Time.time)
                {
                    if(currentScale < screamScaleFactor)
                    {
                        currentScale += transitionStep;
                        if(currentScale > screamScaleFactor)
                        {
                            currentScale = screamScaleFactor;
                        }
                    }
                }
                else
                {
                    currentAction = Action.Standing;
                }
                break;
            case Action.Walking:
                if (currentScale > walkingScaleFactor)
                {
                    currentScale -= transitionStep;
                    if (currentScale < walkingScaleFactor)
                    {
                        currentScale = walkingScaleFactor;
                    }
                }
                else if (currentScale < walkingScaleFactor)
                {
                    currentScale += transitionStep;
                    if (currentScale > walkingScaleFactor)
                    {
                        currentScale = walkingScaleFactor;
                    }
                }
                break;
            case Action.Standing:
                if (currentScale > standingScaleFactor)
                {
                    currentScale -= transitionStep;
                    if (currentScale < standingScaleFactor)
                    {
                        currentScale = standingScaleFactor;
                    }
                }
                break;
        }
        transform.localScale = new Vector3(currentScale, currentScale, 1f);

    }
}
