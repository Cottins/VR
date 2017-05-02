using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargerMove : MonoBehaviour {

    public Vector3 pointB;
    public float _time;

    IEnumerator Start()
    {
        var pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, _time));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, _time));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}
