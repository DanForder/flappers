using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float timer;

    public float maxTime = 1;
    public GameObject pipePrefab;
    public float height;
    public float timeToDestroy = 5;

    private void Start()
    {
        SpawnPipe();
    }

    private void SpawnPipe()
    {
        GameObject newPipe = Instantiate(pipePrefab);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, timeToDestroy);
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
