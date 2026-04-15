using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class patlama : MonoBehaviour
{
    public GameObject patlama1;

    public TextMeshPro gameoverText;
    public bool oyunbitti;
    private void Start()
    {
        gameoverText.gameObject.SetActive(false);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (oyunbitti) return;
        if (!collision.gameObject.CompareTag("patla"))
        {
            oyunbitti = true;
            Instantiate(patlama1, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            gameoverText.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

   
  
    
