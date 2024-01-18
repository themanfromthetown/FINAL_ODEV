using UnityEngine;

public class DusmanKontrol : MonoBehaviour
{
    public Transform nokta1;
    public Transform nokta2;
    public float beklemeSuresi = 2f;
    public float hareketHizi = 3f;

    private Transform hedefNokta;
    private float beklemeZamani;

    void Start()
    {
        hedefNokta = nokta1;
        beklemeZamani = beklemeSuresi;
    }

    void Update()
    {
        HareketEt();
    }

    void HareketEt()
    {
        transform.position = Vector2.MoveTowards(transform.position, hedefNokta.position, hareketHizi * Time.deltaTime);

        if (Vector2.Distance(transform.position, hedefNokta.position) < 0.1f)
        {
            if (beklemeZamani > 0)
            {
                beklemeZamani -= Time.deltaTime;
            }
            else
            {
                beklemeZamani = beklemeSuresi;

                if (hedefNokta == nokta1)
                {
                    hedefNokta = nokta2;
                }
                else
                {
                    hedefNokta = nokta1;
                }

                // Y ekseninde 180 derece dönme
                transform.Rotate(0f, 180f, 0f);
            }
        }
    }
}

