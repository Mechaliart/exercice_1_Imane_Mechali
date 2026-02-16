using UnityEngine;

public class MovementAleatoire : MonoBehaviour
{
    public float vitesseX = 0.1f;
    public float vitesseY = 0.1f;
    public float tauxReduction = 0.001f;
    public float limiteHaut = 10f;
    public float limiteBas = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float nombreAleatoire = Random.Range(0f, 6f);
        Debug.Log(nombreAleatoire);
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

    
      
     }

}
