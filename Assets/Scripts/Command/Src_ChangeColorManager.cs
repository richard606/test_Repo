using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Src_ChangeColorManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

            ControllerCommand.intance.AddCommand(new ChangeColorCameraCommand(new Color(
     Random.Range(0f, 1f),
     Random.Range(0f, 1f),
     Random.Range(0f, 1f)
 ), Camera.main));
        }
    }
}
