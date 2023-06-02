using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathTime : MonoBehaviour
{
    [SerializeField] public GameObject _depth;
    [SerializeField] public GameObject _time;
    [SerializeField] private AudioClip sound;
    public ParticleSystem xplode;
    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject _player;
    public float delay = 1f;
    public Image fillImage;


    void Start()
    {
        xplode.Stop();

    }


    private void FixedUpdate()
    {

        if (fillImage.fillAmount == 0)
        {
            //xplode.Play();
            Instantiate(xplode, _player.transform.position, Quaternion.identity);
            SoundXplosionController.Instance.Sound(sound);

            _player.SetActive(false);
            gameObject.SetActive(false);
            Invoke("delayFunction", delay);


        }

    }



    void delayFunction()
    {
        _time.SetActive(false);
        _depth.SetActive(false);
        panel.SetActive(true);

    }
}
