using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
