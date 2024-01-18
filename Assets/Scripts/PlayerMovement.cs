using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class KarakterHareketi : MonoBehaviour
{
    public float hareketHizi = 5f;

    void Update()
    {
        HareketEt();
        
    }

    void HareketEt()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareket = hareketHizi * Time.deltaTime * new Vector3(yatay, dikey, 0f);
        transform.Translate(hareket);
    }

}

public class EtkilesimKontrolu : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Karakter objesiyle etkile�ime girdi�inde bu metot �a�r�l�r
        if (collision.gameObject.CompareTag("Snake"))
        {
            // Sahneyi ba�tan ba�lat
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}


