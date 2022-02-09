using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCameraCommand : Command
{
    Color color;
    Camera camera;
    Color beforeColor;

    public ChangeColorCameraCommand(Color color, Camera camera) {

        this.color = color;
        this.camera = camera;
    }
    public override void Execute()
    {
        beforeColor = camera.backgroundColor;
        camera.backgroundColor = color;
    }

    public override void Undo()
    {
        camera.backgroundColor = beforeColor;
    }

    // Start is called before the first frame update
  
}
