using UnityEngine;
using System.Collections;

public class MoveRight : MoveIt
{

    // Use this for initialization
    public override void execute(Train t)
    {
        t.mover = new MRight();
    }


}

