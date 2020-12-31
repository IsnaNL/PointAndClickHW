using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOverride : RecieveClicks
{
    
    public override void OnMouseDown()
    {
        base.OnMouseDown();

        if (Actionable())
        {

        }
        if (Interacble())
        {
            stateMachine.state = StateMachineA.State.Entrance;
            didStateHappen = true;
            Debug.Log("State = Start");
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
