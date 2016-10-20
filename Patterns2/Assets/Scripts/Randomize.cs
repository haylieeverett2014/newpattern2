using UnityEngine;
using System.Collections;
using System;

public class Randomize : MoveIt
{

    // Use this for initialization
    public override void execute(Train t)
    {
        t.randomest = new Rando();
    }


}
