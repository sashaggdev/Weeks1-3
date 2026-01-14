using UnityEngine;

public class TriangleScript : MonoBehaviour
{

    public float t = 0;
    public AnimationCurve curve;
    //public Transform y;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        float y = curve.Evaluate(t);
        float x = 0;
        // how make only y??
        transform.localPosition = new Vector2(x, y);
    }
}
