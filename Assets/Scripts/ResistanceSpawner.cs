using UnityEngine;
using UnityEngine.UI;

public class ResistanceSpawner : MonoBehaviour
{
    [SerializeField] private Resistance resistancePrefab;
    private int resistanceCount;

    void Start()
    {
        resistanceCount = 0;
    }

    void Update()
    {

    }

    public void SpawnResistance()
    {
        Resistance resistance = Instantiate(
            resistancePrefab,
            new Vector3(this.transform.position.x, this.transform.position.y + resistanceCount * 1f, this.transform.position.z),
            Quaternion.identity
        );

        resistance.SetResistanceData(
            resistanceCount,
            (Resistance.Color)Random.Range(0, 12),
            (Resistance.Color)Random.Range(0, 12),
            (Resistance.Color)Random.Range(0, 12),
            (Resistance.Color)Random.Range(0, 13),
            (Resistance.Color)Random.Range(0, 13),
            (Resistance.Color)Random.Range(0, 13)
        );

        resistanceCount++;
    }
}
