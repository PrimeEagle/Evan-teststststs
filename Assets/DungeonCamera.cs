using System.Collections;
using UnityEngine;

public class DungeonCamera : MonoBehaviour {
    public Transform target;
    public float smoothTime = .2f;
    Vector3 offset;

    private Vector3 velocity = Vector3.zero;
    // Use this for initialization
    void Start () {
        offset = transform.position - target.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 goalPos = target.position;
        goalPos.y = transform.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
    }
}

