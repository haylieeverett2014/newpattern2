using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    public MoveIt moverCube= new Stop();
    public Train t;

    void OnMouseDown()
    {
        moverCube.execute(t);
    }

    public void Reset(int num)
    {
        if (num == 0)
            moverCube = new MoveLeft();
        else if (num == 1)
            moverCube = new MoveRight();
        else
            moverCube = new Stop();
    }
}
