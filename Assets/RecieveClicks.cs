using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RecieveClicks : MonoBehaviour
{
    public StateMachineA stateMachine;
   
    public bool didStateHappen;
    public virtual void OnMouseDown()
    {
        if (Actionable())
        {

        }
        if (Interacble())
        {

        }
    }
   public virtual bool Actionable (){
        return this;
   }
    public virtual bool Interacble()
    {
        return this;
    }
}
