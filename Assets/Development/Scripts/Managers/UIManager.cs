using System;
using UnityEngine;
using TMPro;
using System.Collections;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI youLoseText;
    private float _scaleSpeed = 1f;
    

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
        gameOverPanel.SetActive(false);
    }

    public void addScore(int score)
    {
        this.score += score;
        scoreText.text = "Score: "+score.ToString();
        StartCoroutine(ScoreEffect());
    }

    IEnumerator ScoreEffect()
    {
        Vector3 originalScale = scoreText.transform.localScale;
        scoreText.transform.localScale = originalScale * 1.2f;
        yield return new WaitForSeconds(0.15f);
        scoreText.transform.localScale = originalScale;
    }

    public void YouLosePanel()
    {
        gameOverPanel.SetActive(true);
        youLoseText.transform.DOScale(new Vector3(7, 7, 7), 7.5f);
    }
    
}
