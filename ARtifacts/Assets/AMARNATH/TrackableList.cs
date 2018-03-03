using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Vuforia;
using UnityEditor;


public class TrackableList : MonoBehaviour
{
    public PanelHandler PanelHandler;
    int position;
    public GameObject outButtons;
    public GameObject[] rooms = new GameObject[6];
    public Color GreenMat;
    private UnityEngine.UI.Image[] da = new UnityEngine.UI.Image[6];
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
        int i;
        for(i=0;i<=5;i++)
        da[i] = rooms[i].GetComponent<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    void Update()
    {
        position = PanelHandler.pos;
        position += 1;
        // Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager();

        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();

        // Iterate through the list of active trackables
        Debug.Log("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables)
        {
			switch (tb.TrackableName) 
			{
			case "1":
				Debug.Log ("Trackable: " + tb.TrackableName);
				if (tb.TrackableName.Equals ("1") || position == 1) {
					PanelHandler.pos = 1;
					SetOutButtonOn ();
					da [0].color = GreenMat;
				}
				position += 1;
				break;
			case "2":
				if (tb.TrackableName.Equals ("2") || position == 2) {
					PanelHandler.pos = 1;
					SetOutButtonOn ();
					da [1].color = GreenMat;
				}
				position += 1;
				break;
			case "3":
				if (tb.TrackableName.Equals ("3") || position == 3) {
					PanelHandler.pos = 2;
					SetOutButtonOn ();
					da [2].color = GreenMat;
				}
				position += 1;
				break;
			case "4":
				if (tb.TrackableName.Equals ("4") || position == 4) {
					PanelHandler.pos = 3;
					SetOutButtonOn ();
					da [3].color = GreenMat;
				}
				position += 1;
				break;
			case "5":
				if (tb.TrackableName.Equals ("5") || position == 5) {
					PanelHandler.pos = 4;
					SetOutButtonOn ();
					da [4].color = GreenMat;
				}
				position += 1;
				break;
			case "6":
				if (tb.TrackableName.Equals ("6") || position == 6) {
					PanelHandler.pos = 5;
					SetOutButtonOn ();
					da [5].color = GreenMat;
				}
				position += 1;
				break;
			}
            PanelHandler.started = true;
        }

    }

    void SetOutButtonOn()
    {
        if (outButtons.activeSelf == false)
            outButtons.SetActive(true);
    }
}

