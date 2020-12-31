using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOverride2 : RecieveClicks
{
    // Start is called before the first frame update
    public override void OnMouseDown()
    {
        base.OnMouseDown();

        if (Actionable())
        {

        }
        if (Interacble())
        {
            stateMachine.state = StateMachineA.State.Ongoing;
            didStateHappen = true;
            Debug.Log("State = Mid");
        }
    }
    public override bool Actionable()
    {
        return base.Actionable();
    }
    public override bool Interacble()
    {
        return true;
    }
}
