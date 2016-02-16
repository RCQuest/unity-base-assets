using UnityEngine;
using System.Collections;

public class EventTester2 : MonoBehaviour
{

    public class Event1 : GameEvent
    {

    }

    public class Event2 : GameEvent
    {

    }

    // Use this for initialization
    void Start ()
    {
        Events.EventDelegate<Event1> action = (e) => Debug.Log("action 1 triggered.");
        Events.EventDelegate<Event1> action2 = (e) => Debug.Log("action 2 triggered.");
        Events.instance.AddListener<Event1>(action);
        Events.instance.AddListener<Event1>(action2);
        
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
