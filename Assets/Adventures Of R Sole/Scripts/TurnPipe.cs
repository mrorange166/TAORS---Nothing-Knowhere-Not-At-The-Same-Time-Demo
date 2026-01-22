using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;
public class TurnPipe : MonoBehaviour
{

    float[] rotations = { 0, 90, 180, 270 };


    private void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
    }

    private void OnMouseDown()
    {
       transform.Rotate(0, 0, 90);
 
    }
}
