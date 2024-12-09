using UnityEngine;

public class test : MonoBehaviour



{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed;
    void Start()
    {
        transform.Translate(Vector3.forward * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= 30){
            Debug.Log("speedが30以上になりました");
        }
    }
}
