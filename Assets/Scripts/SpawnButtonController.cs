using UnityEngine;
using UnityEngine.UI;

public class SpawnButtonController : MonoBehaviour
{
    [SerializeField] private ResistanceSpawner resistanceSpawner;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            resistanceSpawner.SpawnResistance();
        });
    }

    void Update()
    {

    }
}
