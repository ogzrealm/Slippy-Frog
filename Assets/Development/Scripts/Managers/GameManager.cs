using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private SurfaceEffector2D surfaceEffector2D;
    private AudioSource _audioSource;
    private float gameVolume;
    private OptionsMenu optionsMenu;
    private void Awake()
    {
        if(instance!=null) 
        {
            Destroy(gameObject);
        }

        instance = this;
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        float savedVolume = PlayerPrefs.GetFloat("BGVolume", 1f);
        _audioSource.volume = savedVolume;
        
        
    }

    public void FinishLevel()
    {
        StartCoroutine(FinishLevelCoroutine());
    }

    IEnumerator FinishLevelCoroutine()
    {
        surfaceEffector2D.speed = 0;
        
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        StartCoroutine(GameOverCoroutine());
    }

    IEnumerator GameOverCoroutine()
    {
        surfaceEffector2D.speed = 0;
        yield return new WaitForSeconds(1.5f);
        _audioSource.enabled = false;
        UIManager.instance.YouLosePanel();
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    
}
