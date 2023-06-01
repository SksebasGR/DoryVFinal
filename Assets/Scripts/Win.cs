using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] public GameObject _stopCount;
    [SerializeField] public GameObject _stopTimer;
    [SerializeField] public GameObject _win;
    private AudioSource audioSource;
    private bool ban = true;



    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && ban)
        {
            audioSource.Play();
            _win.SetActive(true);
            ban = false;
            Invoke("ExitPanel", 700);
            Time.timeScale = 0f;
            _stopCount.SetActive(false);
            _stopTimer.SetActive(false);
        }
    }


    

    public void ExitPanel()
    {
        _win.SetActive(false);
    }

}
