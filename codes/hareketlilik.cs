using UnityEngine;


public class hareketlilik : MonoBehaviour
{

    Rigidbody rb;
    RaycastHit hit;
    public float a = 25f;
    public float b = 50f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    
    void FixedUpdate()
    {
        float x = Mathf.Sin(Time.time * b);

        float y = Mathf.Sin(Time.time * b);
        rb.AddForce(new Vector3(x, 0, y) * a, ForceMode.Force);



    }

    private void Update()
    {
        Ray isin = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            int degerLayer = LayerMask.NameToLayer("patlayan");
            if (Physics.Raycast(isin, out hit, 1000f))
                Destroy(hit.collider.gameObject);

        }

    }
}

