using UnityEngine;

public class Band : MonoBehaviour
{
    public MaterialData materialData;
    private MeshRenderer meshRenderer;
    private Material bandMaterial;

    public void Start()
    {

    }

    public void SetMaterial(int colorID)
    {
        meshRenderer = this.GetComponent<MeshRenderer>();
        bandMaterial = materialData.materials[colorID];
        meshRenderer.material = bandMaterial;
    }
}
