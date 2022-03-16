using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour, I_Invoker
{

    /*storing input reader to read user input
    and command processor to process the 
    commands being stored. */

    private InputReader _inputReader; 
    private CommandProcessor _commandProcessor;  

    
    void Awake()
    {
        _inputReader = GetComponent<InputReader>(); 
        _commandProcessor = GetComponent<CommandProcessor>(); 

        // ^ caching the values when game starts
        
    }

    void Update()
    {
 
        var direction = _inputReader.ReadInput(); //returns a vector2 direction

        if (direction != Vector2.zero)
        {
            var moveCommand = new MoveCommand(this, direction); //storing new move command
            _commandProcessor.ExecuteCommand(moveCommand); //processing the move command
        }

      

        if (_inputReader.ReadUndo()) 
        {
            _commandProcessor.Undo(); //if 'undo' is detected, undo. 
        }

        if (_inputReader.ReadReplay())
        {
            _commandProcessor.Replay();
        }

        /*if (_inputReader.ReadWallHit())
        /*if (_inputReader.ReadWallHit())
        if (_inputReader.ReadWallHit())
        {
            var wallCommand = new WallCommand(this); 
            _commandProcessor.ExecuteCommand(wallCommand); 
        }*/
        
    }
}
