using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimapplayer : MonoBehaviour {

    public Transform Player;
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newPosition = Player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
	}
}
