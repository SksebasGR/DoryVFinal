using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalMovement : MonoBehaviour
{

    public Vector3 Destination;
    public float Duration;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.DOMove(Destination, Duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
