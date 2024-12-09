using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 0.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!!!");
        Debug.Log("Here is yuulis's scene.");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);

        if (transform.position.z >= 30)
        {
            Debug.Log("speedが30以上になりました");
        }
    }
}
