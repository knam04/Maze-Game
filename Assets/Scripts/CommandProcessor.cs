using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CommandProcessor : MonoBehaviour
{
    public Camera cam;
    public List<ICommand> commandList = new List<ICommand>(); 
    private List<ICommand> replayList = new List<ICommand>();
    private int commandIndex; 
    //public bool empty;

    void Awake()
    {
        GameObject obj = GameObject.Find("Camera");
        cam = obj.GetComponent<Camera>();
    }

    // void Update()
    // {
    //     empty = commandList.Any();
    // }



    public void ExecuteCommand(ICommand command)
    {
        commandList.Add(command); 
        replayList.Add(command);
        command.Execute(); 
        commandIndex = commandList.Count - 1;  //command index (storing most recent command) set to index of the end of command list
    }

    public void Undo()
    {
        if (commandIndex < 0)
        {
            return; 
        }

        commandList[commandIndex].Undo(); 
        commandList.RemoveAt(commandIndex); //undoing and removing command from list
        commandIndex--; //erasing history, bringing down command index

    }

    public void Replay()
    {
        int size = replayList.Count;
        if (replayList.Count <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
            cam.backgroundColor = Color.white;
            replayList[0].Execute();
            replayList.RemoveAt(0);

        // for (int i = 0; i < size; i++){
        //     replayList[i].Execute();
        // }
    }


}
