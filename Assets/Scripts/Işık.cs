using UnityEngine;


public class EtkilesimKontrol : MonoBehaviour
{
    public GameObject kucukObje; // Kucuk tagli objeyi atamak için

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lamba"))
        {
            // Lamba objesini yok et
            Destroy(collision.gameObject);

            // Kucuk objeyi 5 saniyeliğine devre dışı bırak
            if (kucukObje != null)
            {
                kucukObje.SetActive(false);
                Invoke("EtkinlestirKucukObjeyi", 5f);
            }
        }
    }

    void EtkinlestirKucukObjeyi()
    {
        if (kucukObje != null)
        {
            kucukObje.SetActive(true);
        }
    }
}
