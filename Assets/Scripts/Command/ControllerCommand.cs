using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCommand : MonoBehaviour
{
    public static ControllerCommand intance;

    private Stack<Command> _commands = new Stack<Command>();
    // Start is called before the first frame update
    void Start()
    {
        intance = this;
    }

   

    public void AddCommand(Command command) {

        command.Execute();
        _commands.Push(command);

    }

    public void UndoCommand() {

        Command lastCommand = _commands.Pop();
        lastCommand.Undo();
    
    }
}
