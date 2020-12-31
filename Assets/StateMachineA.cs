using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineA : MonoBehaviour
{
    public GameManager gm;

    public enum State
    {
        Entrance,
        Ongoing,
        Ending,
    }
    public State state;
    void Start()
    {
        state = State.Entrance;
    }

   
    void Update()
    {
       
        switch (state)
        {
            case State.Entrance:
                Entrance();
                break;
            case State.Ongoing:
                Ongoing();
                break;
            case State.Ending:
                Ending();
                break;
        }
    }
    void Entrance()
    {
        gm.ColorChangingBoxMR.material = gm.mats[0];
       
    }
    void Ongoing()
    {
        gm.ColorChangingBoxMR.material = gm.mats[1];
       

    }
    void Ending()
    {
        gm.ColorChangingBoxMR.material = gm.mats[2];
      

    }
     public void SetState(State s)
     {
        state = s;
     }
     public void nextState()
    {
        if(state > State.Ending)
        {
            state = State.Entrance;
        }
        state++;
    }
    public void Previous()
    {
        if (state < State.Entrance)
        {
            state = State.Ending;
        }
        state--;
    }
}
