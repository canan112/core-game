using UnityEngine;

public class ekranayaz : MonoBehaviour
{
  
    public static ekranayaz Instance { get; private set; }
    public GameObject gameovertext;

    private void Awake()
    {
        if (Instance == null) 
        { 
            Instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }


    }
     public void mesaj()
    {
        if (gameovertext != null)
        {
            gameovertext.SetActive(true);
            Debug.Log("oyun bitti yazýsý ekrana verildi");

        }
    }
    
}
