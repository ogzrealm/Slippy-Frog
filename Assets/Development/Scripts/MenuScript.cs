using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public AudioClip[] AudioClips;
    private AudioSource _audioSource;

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
        yield return new WaitForSeconds(0.05f);
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
        
    }
    
    
}
