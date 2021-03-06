using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTriggers : MonoBehaviour
{

    public PlayerObserver playerObserver;

    public bool inGoal;

    // Start is called before the first frame update
    void Start()
    {
        playerObserver = GameObject.Find("Player Observer").GetComponent<PlayerObserver>();

        inGoal = false;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != "Untagged")
        {
            inGoal = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inGoal = false;
    }
}
