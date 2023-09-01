using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        //Instantiate is used to create new instances of game objects, ususally used with prefabs
        //Quartation is data type that is used to represent rotation in 3D spaces. Quartation.identity is predefined constant that reps neutral
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        //Random value created is kept between min max values, then multiplied by the x, y, and z from the Vector3
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight); //Vector3.up has a preset of (0, 1, 0) 
    }
}
