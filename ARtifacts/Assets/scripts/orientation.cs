using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientation : MonoBehaviour {

    public bool portrait=true;
	// Use this for initialization
	void Start ()
    {
        Screen.orientation = ScreenOrientation.Portrait;	
	}

    // Update is called once per frame
    void Update()
    {
        if (portrait == false && Screen.orientation== ScreenOrientation.Portrait)
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        if (portrait == true && Screen.orientation == ScreenOrientation.LandscapeLeft)
            Screen.orientation = ScreenOrientation.Portrait;

            }
              
}
