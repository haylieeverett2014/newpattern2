using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {
    
    public MoveIt moverS = new MoveLeft();
    public Train t;

    void OnMouseDown()
    {
        moverS.execute(t);
    }

    public void Reset(int num)
    {
        if (num == 0)
            moverS = new MoveLeft();
        else if (num == 1)
            moverS = new MoveRight();
        else
            moverS = new Stop();
    }
}
