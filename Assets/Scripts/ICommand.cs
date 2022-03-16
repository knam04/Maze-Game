public abstract class ICommand
{
    protected I_Invoker _invoker; 

    public ICommand(I_Invoker invoker)
    {
        _invoker = invoker; 
    }

    public abstract void Execute(); 

    public abstract void Undo(); 

    public abstract void Replay();

    /*General comment: for 'replay' of maze... when the IEnumerator countdown ends, 
    we want to replay the player's path and compare it to the original --> will require 
    playback of the cached events in a list once the enumerator stops

    Also can have cached events play out over the certain amount of time using the enumator too*/


}
