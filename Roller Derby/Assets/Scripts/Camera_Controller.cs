using UnityEngine;
using System.Collections;

public class Camera_Controller : MonoBehaviour {

    public GameObject player;
    public float moveSpeed = 60;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Vector3 newPos = new Vector3();
        newPos.x = Mathf.Lerp(player.transform.position.x, transform.position.x, Time.deltaTime * moveSpeed);
        newPos.y = Mathf.Lerp(player.transform.position.y + 4.6f, transform.position.y, Time.deltaTime * moveSpeed);
        newPos.z = -10;
        transform.position = newPos;
	}
}
