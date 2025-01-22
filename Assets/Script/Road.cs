using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject gasPrefab;
    public GameObject roadPrefab;
    private float moveSpeed = 10f;
    private static Vector3 targetPosition = new Vector3(0f, -1f, 30f);
    [SerializeField] private List<Transform> spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        RandomSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * (moveSpeed * Time.deltaTime);

        if (transform.position.z < -30)
        {
            GameObject instant = Instantiate(roadPrefab, targetPosition, Quaternion.identity);
            instant.transform.parent = this.transform.parent;
            Destroy(gameObject);
        }
    }

    void RandomSpawn()
    {
        GameObject gas = Instantiate(gasPrefab, spawnPoints[Random.Range(0, spawnPoints.Count)].position, Quaternion.identity);
        gas.transform.parent = transform;
    }
}
