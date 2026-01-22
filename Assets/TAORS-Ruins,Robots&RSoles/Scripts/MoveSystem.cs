using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class MoveSystem : MonoBehaviour
{

    public GameObject correctForm;
    private bool moving;

    private float startPosX;
    private float startPosY;

    private Vector2 resetPosition;

    private bool finish;

    // Start is called before the first frame update
    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {

                Vector3 mousePos;
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY);

                Debug.Log("Moving True!");
            }
        }

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Down!");
            Vector3 mousePos;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;

                    if (this.transform.position == correctForm.transform.position)
        {
            finish = false;
            GameObject.Find("PointsHandler").GetComponent<WinScript>().RemovePoints();
            Debug.Log("-- points");
        }

        }
    }

    private void OnMouseUp()
    {
        Debug.Log("Mouse Up!");
        moving = false;


        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f)
        {
            this.transform.position = new Vector2(correctForm.transform.position.x, correctForm.transform.position.y);
            finish = true;

            GameObject.Find("PointsHandler").GetComponent<WinScript>().AddPoints();
            Debug.Log("++ points");
        }
        else
        {
            this.transform.localPosition = new Vector2(resetPosition.x, resetPosition.y);
        }

    }
}
