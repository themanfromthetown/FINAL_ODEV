using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;  // UI üzerinde score'u gösterecek olan Text nesnesi

    private int currentScore = 0;
    private int maxScore = 3;  // Toplanacak toplam nesne sayýsý

    private void Start()
    {
        UpdateScoreText();
    }

    // Score'u artýrma fonksiyonu
    public void IncreaseScore()
    {
        if (currentScore < maxScore)
        {
            currentScore++;
            UpdateScoreText();

            // Burada isterseniz baþka iþlemler de yapabilirsiniz, örneðin labirentte kapýlarý açma, yeni seviyeye geçiþ vs.
        }
    }

    // Score'u ekranda güncelleyen fonksiyon
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore + "/" + maxScore;
    }
}
