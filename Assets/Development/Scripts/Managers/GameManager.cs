using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private SurfaceEffector2D surfaceEffector2D;
    private void Awake()
    {
        if(instance!=null) 
        {
            Destroy(gameObject);
        }

        instance = this;
    }

    public void FinishLevel()
    {
        StartCoroutine(FinishLevelCoroutine());
    }

    IEnumerator FinishLevelCoroutine()
    {
        surfaceEffector2D.speed = 0;
        yield return new WaitForSeconds(1);
        Debug.Log("Next Level");
    }

    public void GameOver()
    {
        StartCoroutine(GameOverCoroutine());
    }

    IEnumerator GameOverCoroutine()
    {
        surfaceEffector2D.speed = 0;
        yield return new WaitForSeconds(1.5f);
        UIManager.instance.YouLosePanel();
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
