using System.Collections.Generic;
using UnityEngine;

public class GroundHandler : MonoBehaviour {

    public GameObject Ground;
    private Transform characterPosition;
    private Player playerScript;
    private Rigidbody2D mainCamera;
    private List<GameObject> grounds = new List<GameObject>();

    // Use this for initialization
    void Start () {
        characterPosition = GameObject.Find("Character").transform;
        playerScript = GameObject.Find("Character").GetComponent<Player>();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Rigidbody2D>();
        for (int x = 0; x <= 10; x++) createNewGround();
    }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D col)
    {
        destroyLastGround();
        createNewGround();
    }

    private void destroyLastGround()
    {
        GameObject groundToDestroy = grounds[0];
        Destroy(groundToDestroy);
        grounds.Remove(groundToDestroy);
    }

    private void createNewGround()
    {
        float characterAbscissa = characterPosition.position.y;

        float camMaxY = mainCamera.position.y + 1;

        float jumpHeight = playerScript.jumpSpeed + characterAbscissa;

        float groundMaxY = 0;
        float groundMinY = 0;

        if (grounds.Count == 0)
        {
            groundMaxY = 3;
            groundMinY = 1;
        }
        else
        {
            groundMaxY = grounds[grounds.Count - 1].transform.position.y + 3;
            groundMinY = grounds[grounds.Count - 1].transform.position.y + 1;
        }

        float newGroundX = Random.Range(-4.0f, 4.0f);
        float newGroundY = Random.Range(groundMinY, groundMaxY);

        GameObject newGround = Instantiate(Ground, new Vector2(newGroundX, newGroundY), Quaternion.identity) as GameObject;
        newGround.transform.parent = this.transform.parent;
        grounds.Add(newGround);
    }
    
}
