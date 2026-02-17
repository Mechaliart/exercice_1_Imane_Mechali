using UnityEngine;

public class AgrandissementObstacle : MonoBehaviour
{   //======Agrandissement et déplacement des cercles (sur le meme code)======
    
    
    
    // public float scale = 0.01f;
    // public float maxScale = 1.5f;
    // public float minScale = 1.0f;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float scale = 0.01f;
    public float maxScale = 1.5f;
    public float minScale = 1.0f;

    public float vitesseX = 0f;      
    public float vitesseY = -0.1f;   

    public float limiteBas = -10f;

    private Vector3 positionInitiale;
    void Start()
    {
    
        positionInitiale = transform.position;

       
        transform.localScale = new Vector3(minScale, minScale, 1);

    }

    // Update is called once per frame
    void Update()
    {
   
            
        transform.Translate(vitesseX, vitesseY, 0);

        
        transform.localScale += new Vector3(scale, scale, 0);

        
        if (transform.localScale.x >= maxScale)
        {
            transform.localScale = new Vector3(maxScale, maxScale, 1);
            scale = -scale;
        }
        else if (transform.localScale.x <= minScale)
        {
            transform.localScale = new Vector3(minScale, minScale, 1);
            scale = -scale;
        }

        
        if (transform.position.y < limiteBas)
        {
            transform.position = positionInitiale;

            
            transform.localScale = new Vector3(minScale, minScale, 1);

            
            scale = Mathf.Abs(scale);
        }
    }

        
    }

