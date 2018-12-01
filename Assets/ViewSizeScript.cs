using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSizeScript : MonoBehaviour {
    private enum Action { Screaming, Standing, Walking};

    private static float screamStart = 0;
    public static float screamBuildUpTime = 0.5f;
    public static float screamBuildDowntime = 0.75f;
    public static int screamDuration = 3;
    public static int screamCooldownSeconds = 8;
    private static Vector2 standingScaleFactor = new Vector3(0.4f, 0.4f, 1);
    private static Vector2 walkingScaleFactor = new Vector3(0.6f, 0.6f, 1);
    private static Vector2 screamScaleFactor = new Vector3(1.4f, 1.4f, 1);

    private static Action currentAction;

    // Use this for initialization
    void Start () {
        currentAction = Action.Standing;
    }
	
    public static void setToScreaming()
    {
        if (screamStart == 0 || screamStart + screamBuildUpTime + screamDuration + screamBuildDowntime + screamCooldownSeconds < Time.time) {
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
        Debug.Log("screamStart: " + screamStart.ToString() + " currentTime: " + Time.time.ToString());
        switch (currentAction)
        {
            case Action.Screaming:
               if(screamStart + screamBuildUpTime > Time.time)
                {
                    float transitionFactor = (Time.time - screamStart) / screamBuildUpTime;
                    float currentYXScaleFactor = (screamScaleFactor.x - standingScaleFactor.x) * transitionFactor + standingScaleFactor.x;
                    transform.localScale = new Vector3(currentYXScaleFactor, currentYXScaleFactor, 1f);
                }
                else if(screamStart + screamBuildUpTime + screamDuration > Time.time)
                {
                    transform.localScale = screamScaleFactor;
                }else if(screamStart + screamBuildUpTime + screamDuration + screamBuildDowntime > Time.time)
                {
                    float transitionFactor = 1 - ((Time.time - (screamStart + screamBuildUpTime + screamDuration)) / screamBuildDowntime);
                    float currentYXScaleFactor = (screamScaleFactor.x - standingScaleFactor.x) * transitionFactor + standingScaleFactor.x;
                    transform.localScale = new Vector3(currentYXScaleFactor, currentYXScaleFactor, 1f);
                }
                else
                {
                    currentAction = Action.Standing;
                }
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
