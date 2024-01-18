using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;  // UI �zerinde score'u g�sterecek olan Text nesnesi

    private int currentScore = 0;
    private int maxScore = 3;  // Toplanacak toplam nesne say�s�

    private void Start()
    {
        UpdateScoreText();
    }

    // Score'u art�rma fonksiyonu
    public void IncreaseScore()
    {
        if (currentScore < maxScore)
        {
            currentScore++;
            UpdateScoreText();

            // Burada isterseniz ba�ka i�lemler de yapabilirsiniz, �rne�in labirentte kap�lar� a�ma, yeni seviyeye ge�i� vs.
        }
    }

    // Score'u ekranda g�ncelleyen fonksiyon
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore + "/" + maxScore;
    }
}
