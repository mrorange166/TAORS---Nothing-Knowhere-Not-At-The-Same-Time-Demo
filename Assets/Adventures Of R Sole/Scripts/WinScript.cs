using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class WinScript : MonoBehaviour
{

    private int pointsToWin;
    private int CurrentPoints;
    public GameObject myPieces;

    public ActionListAsset actionlist;

    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = myPieces.transform.childCount;

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentPoints == pointsToWin)
        {
            //WIN
            transform.GetChild(0).gameObject.SetActive(true);
            runActionList();

        }
        Debug.Log(CurrentPoints);
    }

    public void AddPoints()
    {
        CurrentPoints++;

    }

    public void RemovePoints()
    {
        CurrentPoints--;
    }


    public void runActionList()
    {

        actionlist.Interact();
    }

}
