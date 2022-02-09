using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeCharCommand : Command
{
    char letter;
    string prevText;
    Text text;
    public TypeCharCommand(char letter,Text text) {

        this.letter = letter;

        this.text = text;
    }
    public override void Execute()
    {
        prevText = text.text;
        text.text += letter;
    }

    public override void Undo()
    {
        text.text = prevText;
        
    }

    
}
