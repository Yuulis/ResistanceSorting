using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab; // 生成するPrefab

    // ボタンが押されたときに呼び出される関数
    public void SpawnObject()
    {
        if (objectPrefab != null)
        {
            // 固定位置と回転角度を設定
            Vector3 spawnPosition = new Vector3(0, 1, -7);
            Quaternion spawnRotation = Quaternion.Euler(-90, 0, 90);

            // オブジェクトを生成
            Instantiate(objectPrefab, spawnPosition, spawnRotation);
            Debug.LogWarning("オブジェクトを生成しました");

        }
        else
        {
            Debug.LogWarning("Prefabが設定されていません");
        }
    }
}
