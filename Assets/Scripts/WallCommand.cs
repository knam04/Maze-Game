using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCommand : ICommand
{

    public WallCommand(I_Invoker invoker) :base(invoker)
    {   

    }

    public override void Execute()
    {
        //command to make the player offset a little when hitting the walls
        //Debug.log("hit");
    }

    public override void Undo()
    {
        
    }

    public override void Replay()
    {
        
    }

}
