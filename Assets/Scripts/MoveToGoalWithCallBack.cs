using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class MoveToGoalWithCallBack : MonoBehaviour {

    [SerializeField] Transform target;
    public float moveTime = 1.0f;
    public UnityEvent atDestinationCallback;

	// Use this for initialization
	void Start () {
	   StartCoroutine(MoveToTarget());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator MoveToTarget() {
        float t = 0;

        Vector3 startPosition = transform.position;
        Vector3 targetPosition = target.position;

        while (t < moveTime) {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(startPosition, targetPosition, t/moveTime);

            yield return null;
        }

        transform.position = target.position;
        atDestinationCallback.Invoke();
    }

    public void MoveAgain() {
        StartCoroutine(MoveToTarget());
    }
}
