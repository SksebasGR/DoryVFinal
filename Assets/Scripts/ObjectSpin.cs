using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectSpin : MonoBehaviour
{
    [SerializeField] public Transform _shape;
    [SerializeField] private float _cycleLength = 3;
    // Start is called before the first frame update
    void Start()
    {
        _shape.DORotate(new Vector3(0, 360, 0), _cycleLength * 0.5f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
