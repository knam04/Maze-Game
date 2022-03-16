using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Vector2 _direction; 

    // 'base' used if using abstract class instead of interface?

    public MoveCommand(I_Invoker invoker, Vector2 direction) : base(invoker) 
    {
        _direction = direction; 
    }

    public override void Execute()
    {
        _invoker.transform.position += (Vector3) _direction * 0.01f; 
    }

    public override void Undo()
    {
        _invoker.transform.position -= (Vector3) _direction * 0.01f; 

    }

    public override void Replay()
    {
        //_invoker.transform.position *= (Vector3) _direction * 0.01f;
    }

}
