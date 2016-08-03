using UnityEngine;
using System.Collections;

public class Camera_Controller : MonoBehaviour {

    public GameObject player;
    public float moveSpeed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Vector3 newPos = new Vector3();
        //newPos.x = Mathf.Lerp(transform.position.x, player.transform.position.x, Time.deltaTime * moveSpeed);
        //newPos.y = Mathf.Lerp(transform.position.y, player.transform.position.y + 4.6f, Time.deltaTime * moveSpeed);
        newPos.x = player.transform.position.x;
        newPos.y = player.transform.position.y + 4.6f;
        newPos.z = -10;
        transform.position = newPos;
	}
}
