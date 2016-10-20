using UnityEngine;
using System.Collections;

public class Cylinder : MonoBehaviour {


    public MoveIt moverCyl= new MoveRight();
    public Train t;
    //Physics.queriesHitTriggers = true;

    void OnMouseDown()
    {
            moverCyl.execute(t);
    }

    public void Reset(int num)
    {
        if (num == 0)
            moverCyl = new MoveLeft();
        else if (num == 1)
            moverCyl = new MoveRight();
        else
            moverCyl = new Stop();
    }

}
