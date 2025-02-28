using UnityEngine;

public class ClawBehaviour : MonoBehaviour
{
    public float speed;

    public Vector2 newPosition;
    public Vector3 mouseP;
    float constY = 3.0f;

    Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 clawPos = new Vector3(mouseP.x, constY, -0.1f);
        mouseP = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = Vector2.MoveTowards(transform.position, clawPos, speed * Time.fixedDeltaTime);
        transform.position = newPosition;
    }
}
