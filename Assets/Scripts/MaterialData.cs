using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MaterialData", menuName = "Scriptable Objects/MaterialData")]
public class MaterialData : ScriptableObject
{
    public List<Material> materials;
}
