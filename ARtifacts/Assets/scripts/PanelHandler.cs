using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelHandler : MonoBehaviour {
    public GameObject[] artfs=new GameObject [6];

    public static int pos=1;
    public  bool started = false;
	void Update ()
    {
        print(pos);
		if(artfs[pos].activeSelf==false&&started==true)
        {
            diableAll();
            artfs[pos].SetActive(true);
        }	
	}

    public void diableAll()
    {
       for (int i = 0; i < 6; i++)

        
            artfs[1].SetActive(false);
            
    }

    public void next()
    {
        pos += 1;
    }

    public void prev()
    {
        pos -= 1;
    }
}
