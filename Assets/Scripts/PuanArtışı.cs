using UnityEngine;
using UnityEngine.SceneManagement;

public class RatController : MonoBehaviour
{
    private bool hasCollided = false;
    public int score = 0;
    public string nextSceneName = "Scene2"; // İleride kullanılacak diğer sahnenin adı

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided && collision.gameObject.CompareTag("Cheese"))
        {
            score++;
            Debug.Log("Score: " + score);

            // Score 3 olduğunda ve çıkışa ulaşıldığında Scene2'ye geçiş yap
           

            hasCollided = true;
        }
        if (collision.gameObject.CompareTag("Exit") && score == 3)
        {
            SceneManager.LoadScene("Scene2");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cheese"))
        {
            hasCollided = false;
        }
    }
}
