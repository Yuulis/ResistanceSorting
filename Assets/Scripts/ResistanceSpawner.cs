using UnityEngine;

public class ResistanceSpawner : MonoBehaviour
{
    [SerializeField] private GameObject resistancePrefab;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnResistance();
        }
    }

    private void SpawnResistance()
    {
        GameObject resistanceObj = Instantiate(resistancePrefab, transform.position, Quaternion.identity);
        Resistance resistance = resistanceObj.GetComponent<Resistance>();
        resistance.id = Random.Range(0, 1000);
        resistance.bands.Add((Resistance.Color)Random.Range(0, 11));
    }
}
