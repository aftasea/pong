using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int scorep1;
    public static int scorep2;

    // Start is called before the first frame update
    void Start()
    {
        scorep1 = 0;
        scorep2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 200, 30), "Player 1 Score: " + scorep1);
        GUI.Box(new Rect(Screen.width - 250, 10, 200, 30), "Player 2 Score: " + scorep2);
    }
}
