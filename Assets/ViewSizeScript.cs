using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSizeScript : MonoBehaviour {
    private enum Action { Screaming, Standing, Walking};

    private static int screamCount = 0;
    public static int maxScreamFrames = 120;
    private static Vector2 standingScaleFactor = new Vector3(0.4f, 0.4f, 1);
    private static Vector2 walkingScaleFactor = new Vector3(0.6f, 0.6f, 1);
    private static Vector2 screamScaleFactor = new Vector3(1.4f, 1.4f, 1);

    private static Action currentAction;

    // Use this for initialization
    void Start () {
        currentAction = Action.Standing;
    }
	
    public static void setToScreamSize()
    {
        if (screamCount == 0) {
            currentAction = Action.Screaming;
        }
    }

    public static void setToWalking()
    {
        currentAction = Action.Walking;
    }

    public static void setToStanding()
    {
        currentAction = Action.Standing;
    }


    // Update is called once per frame
    void Update () {
        switch (currentAction)
        {
            case Action.Screaming:
                ++screamCount;
                if(screamCount >= maxScreamFrames)
                {
                    currentAction = Action.Standing;
                }
                transform.localScale = screamScaleFactor;
                break;
            case Action.Walking:
                transform.localScale = walkingScaleFactor;
                break;
            case Action.Standing:
                transform.localScale = standingScaleFactor;
                break;
        }
	}
}
