using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;
public class PipeScript : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite OldSprite;

    float[] rotations = { 0, 90, 180, 270 };

    public float[] correctRotations;
    [SerializeField]
    bool isPlaced = false;

    int possibleRots = 1;

    GameManagerPipe gameManager;
    public AudioSource soundSource;
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerPipe>();
    }

    private void Start()
    {


        possibleRots = correctRotations.Length;

        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if (possibleRots > 1)
        {
            if (transform.eulerAngles.z == correctRotations[0] || transform.eulerAngles.z == correctRotations[1])
            {
                isPlaced = true;
                gameManager.correctMove();

            }
        }
        else if (transform.eulerAngles.z == correctRotations[0])
        {
            isPlaced = true;
            gameManager.correctMove();

        }

    }

    private void OnMouseDown()
    {

        transform.Rotate(0, 0, 90);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));
        soundSource.Play();


        if (possibleRots > 1)
        {
            if (transform.eulerAngles.z == correctRotations[0] || transform.eulerAngles.z == correctRotations[1] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();

            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();

            }
        }
        else
        {
            if (transform.eulerAngles.z == correctRotations[0] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();

            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();

            }
        }
    }
    public void ChangeSpriteNew()
    {
        spriteRenderer.sprite = newSprite;
    }
}
