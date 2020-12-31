using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOverride3 : RecieveClicks
{
    public ObjectOverride object1;
    public ObjectOverride2 object2;
    public bool canEnd;
    public override void OnMouseDown()
    {
        base.OnMouseDown();

        if (Actionable())
        {
            if (object1.didStateHappen && object2.didStateHappen)
            {
                stateMachine.state = StateMachineA.State.Ending;
                canEnd = true;
                Debug.Log("State = End");
            }
        }
        if (Interacble())
        {
          
        }
    }
    public override bool Actionable()
    {
        return true;
    }
    public override bool Interacble()
    {
        return false;
    }
}
