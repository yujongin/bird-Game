using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject WallPrefab;

    public float SpawnTerm = 2;

    float spawnTimer = 0;
    private float score;
    public float Score { get { return score; } }


    void Awake()
    {
        Instance = this;
    }


    void Start()
    {
        score = 0;
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        score += Time.deltaTime;

        if (spawnTimer > SpawnTerm)
        {
            spawnTimer -= SpawnTerm;

            GameObject obj = Instantiate(WallPrefab);
            obj.transform.position = new Vector2(10, Random.Range(-2f, 2f));
        }
    }
}
