using UnityEngine;

public class CandySpawning : MonoBehaviour
{
    public GameObject[] candyVariants;
    GameObject newObject;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public Vector2 newPosition;
    public Vector3 mouseP;

    Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnCandy();
        mouseP = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = new Vector3(mouseP.x, 3.0f, 0.0f);
    }

    void spawnCandy() {
        int numVariants = candyVariants.Length;
        if (numVariants > 0 && Input.GetMouseButtonDown(0) == true) {
            int selection = Random.Range(0, numVariants);
            newObject = Instantiate(candyVariants[selection], newPosition, Quaternion.identity);

        }
    }

    /* public void setBounds(float miX, float maX float miY, float maY) {
        minX = miX;
        maxX = maX;
        minY = miY;
        maxY = maY;
    }

    Vector2 limitMove() {

    }
    */
}
