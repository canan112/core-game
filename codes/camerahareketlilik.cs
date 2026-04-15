using UnityEngine;

public class camerahareketlilik : MonoBehaviour
{
    public Transform cameraPivot;
    public float farehýzý = 300f;
    public float miny = -60f;
    public float maxy = 60f;
    float xrotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    
    void Update()
    {
        float mousex = Input.GetAxis("Mouse x") * farehýzý * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse y") * farehýzý * Time.deltaTime;
        transform.Rotate(Vector3.up * mousex);
        xrotation -= mousey;
        xrotation = Mathf.Clamp(xrotation, miny, maxy);
        if(cameraPivot!=null)
        {
            cameraPivot.Rotate(Vector3.up * mousex);
        }
        cameraPivot.localRotation = Quaternion.Euler(xrotation, 0f, 0f);


    }
}
