using UnityEngine;
using System.Collections;
using System;

public class Train : MonoBehaviour
{
    public movement mover= new StopIt();
    public randomer randomest= null;
    private Rigidbody rb;
    public Cylinder set;
    public Sphere setS;
    public Cube setC;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        mover.move(rb);
        if (randomest != null)
        {
            randomest.freak(set, setS, setC);
        }
        randomest = null;
	}
};

public abstract class randomer
{
    public abstract void freak(Cylinder set,Sphere setS,Cube setC);
};

public class Rando : randomer
{

    public override void freak(Cylinder set,Sphere setS,Cube setC)
    {
        float number = UnityEngine.Random.Range(0, 6);
        if (number == 0)
        {
            set.Reset(0);
            setS.Reset(1);
            setC.Reset(2);
        }
        else if (number == 1)
        {
            set.Reset(0);
            setS.Reset(2);
            setC.Reset(1);
        }
        else if (number == 2)
        {
            set.Reset(1);
            setS.Reset(0);
            setC.Reset(2);
        }
        else if (number == 3)
        {
            set.Reset(1);
            setS.Reset(2);
            setC.Reset(0);
        }
        else if (number == 4)
        {
            set.Reset(2);
            setS.Reset(1);
            setC.Reset(0);
        }
        else if(number== 5)
        {
            set.Reset(2);
            setS.Reset(0);
            setC.Reset(1);
        }
        else
        {
            //blank
        }
    }
};

public abstract class movement
{
    public abstract void move(Rigidbody rb);
};

public class MRight: movement
{
    public override void move(Rigidbody rb)
    {
        rb.AddForce(10, 0, 0);
    }
};
public class MLeft : movement
{
    public override void move(Rigidbody rb)
    {
        rb.AddForce(-10, 0, 0);
    }
};
public class StopIt : movement
{
    public override void move(Rigidbody rb)
    {
        rb.AddForce(0, 0, 0);
    }
}