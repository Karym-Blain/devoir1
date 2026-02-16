using UnityEngine;

public class mouvement : MonoBehaviour
{
    public float vitesseRotation =0.02f;
    
    public float vittesseY = 0.1f;
    public float tauxDeReduction = 0.006f;
    
    public float hautY = 4;
    public float basY = -4;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotation//
        transform.Rotate(0f,0f, vitesseRotation);
        //translation bas a haut// //permet translation dans la page//
        transform.Translate(0f, vittesseY,0f, Space.World);

        //devient plus petit//
        float nouvelleTaille = transform.localScale.x - tauxDeReduction;
        
        if(nouvelleTaille > 0)
        {
            transform.localScale = new Vector3(nouvelleTaille,nouvelleTaille,1f);
        }
        else if (nouvelleTaille < 0.5)
        {
            
            transform.localScale = new Vector3(2f,2f,1f);
        }
        // resqpawn quand sa arrive au top//
        if (transform.position.y > hautY)
        {
            float xAleatoire = Random.Range(-4f,4f);
            transform.position = new Vector3(xAleatoire, basY,transform.position.z);
        }
     
    }
}
