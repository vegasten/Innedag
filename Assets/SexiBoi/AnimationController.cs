using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Button _waveButton;
    [SerializeField] private Button _tauntButton;
    [SerializeField] private Button _danceButton;
    [SerializeField] private Animator _animator;
    [SerializeField] private ParticleSystem _surpriseGas;

    private void Start()
    {
        _waveButton.onClick.AddListener(waveButtonClicked);
        _tauntButton.onClick.AddListener(tauntButtonClicked);
        _danceButton.onClick.AddListener(danceButtonClicked);
    }

    private void danceButtonClicked()
    {
        _animator.SetTrigger("DanceTrigger");
    }

    private void waveButtonClicked()
    {
        _animator.SetTrigger("WaveTrigger");
    }

    private void tauntButtonClicked()
    {
        _animator.SetTrigger("TauntTrigger");
        StartCoroutine(gasCoroutine());
    }

    private IEnumerator gasCoroutine()
    {
        yield return new WaitForSeconds(3.7f);
        _surpriseGas.Play();
    }
}
