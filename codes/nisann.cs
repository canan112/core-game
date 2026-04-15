using UnityEngine;
using UnityEngine.UI;

public class nisann : MonoBehaviour
{
    
    void Update()
    {
        
            GetComponent<RectTransform>().position = Input.mousePosition;
        
    }
}
