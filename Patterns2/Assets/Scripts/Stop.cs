using UnityEngine;
using System.Collections;
using System;

public class Stop : MoveIt
{

    // Use this for initialization
    public override void execute(Train t)
    {
        t.mover = new StopIt();
    }


}

