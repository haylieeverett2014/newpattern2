using UnityEngine;
using System.Collections;

public class Capsule : MonoBehaviour {

    private MoveIt moverCap = new Randomize();
    public Train t;
    
    void OnMouseDown ()
    {
        moverCap.execute(t);
    }

}
