using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Src_TypingManager : MonoBehaviour
{
    // Start is called before the first frame update
    private readonly Array keyCodes = Enum.GetValues(typeof(KeyCode));

    public Text text;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Backspace)) {

            ControllerCommand.intance.UndoCommand();

        }
        else if(Input.GetKeyDown(KeyCode.Space)){ 
        
        }
        
        
        else
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in keyCodes)
            {
               
                if (Input.GetKey(keyCode))
                {
                    ControllerCommand.intance.AddCommand(new TypeCharCommand(char.Parse(keyCode.ToString()), text));
                    break;
                }
            }
        }
    }
}
