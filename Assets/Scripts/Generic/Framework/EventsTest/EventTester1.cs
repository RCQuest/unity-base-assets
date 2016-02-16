using UnityEngine;
using System.Collections;

public class EventTester1 : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        Events.instance.Raise(new EventTester2.Event1());
    }
}
