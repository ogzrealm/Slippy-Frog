using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    private AudioSource _audioSource;
    [SerializeField] private AudioClip flipSoundEffect;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void PlayFlipEffect() 
    {
        if (!_audioSource.isPlaying)
        {
            float randomPitch = Random.Range(0.8f, 1.1f);
            _audioSource.pitch = randomPitch;
            _audioSource.PlayOneShot(flipSoundEffect);
        }
        
    }
    
}
