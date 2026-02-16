using UnityEngine;

public class AgrandissementObstacle : MonoBehaviour
{
    public float scale = 0.01f;
    public float maxScale = 1.5f;
    public float minScale = 1.0f;
    public float vitesseX = 0.1f;
    public float vitesseY = 0.1f;
    public float tauxReduction = 0.001f;
    public float limiteHaut = 10f;
    public float limiteBas = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // float nombreAleatoire = Random.Range(0f, 6f);
       transform.localScale = new Vector3(minScale, minScale, 1);
       transform.Translate(vitesseX, vitesseY, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vitesseX, vitesseY, 0);
      if (transform.position.y > limiteHaut)
      {
        float nouvellePositionX = transform.position.x;
        float nouvellePositionY =limiteBas;
        transform.position = new Vector2(nouvellePositionX, nouvellePositionY);
      }
    //   if (transform.localScale.x >= maxScale || transform.localScale.x <= minScale)
    //     {
    //         // scale *= -1.0f;
    //         vitesseX *= -1.0f;
    //         vitesseY *= -1.0f;
    //     }

        transform.localScale += new Vector3(scale, scale, 0);
        if (transform.localScale.x > maxScale || transform.localScale.x < minScale)
        {
            scale *= -1.0f; 
        }
        
    }
}
