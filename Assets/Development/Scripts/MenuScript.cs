using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuScript : MonoBehaviour
{
    public AudioClip[] AudioClips;
    private AudioSource _audioSource;
    [SerializeField] private GameObject optionsPanel;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayButton()
    {
        StartCoroutine(PlayButtonAnimation());
    }

    private IEnumerator PlayButtonAnimation()
    {
        _audioSource.PlayOneShot(AudioClips[0]);
        yield return new WaitForSeconds(0.07f);
        SceneManager.LoadScene(1);
    }

    public void OptionsButton()
    {
        StartCoroutine(OptionsButtonAnimation());
    }

    private IEnumerator OptionsButtonAnimation()
    {
        _audioSource.PlayOneShot(AudioClips[1]);
        yield return new WaitForSeconds(0.05f);
        optionsPanel.SetActive(true);
    }

    public void BackButton()
    {
        StartCoroutine(BackButtonAnimation());
    }

    private IEnumerator BackButtonAnimation()
    {
        _audioSource.PlayOneShot(AudioClips[3]);
        yield return new WaitForSeconds(0.05f);
        optionsPanel.SetActive(false);
    }

    public void QuitButton()
    {
        StartCoroutine(QuitButtonAnimation());
    }
    private IEnumerator QuitButtonAnimation()
    {
        _audioSource.PlayOneShot(AudioClips[2]);
        yield return new WaitForSeconds(0.05f);
        Application.Quit();
    }
    
}
