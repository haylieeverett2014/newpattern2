using UnityEngine;
using System.Collections;

public class MoveLeft : MoveIt {

	// Use this for initialization
	public override void execute (Train t)
    {
        t.mover = new MLeft();
    }
	
	
}
