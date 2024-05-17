using UnityEngine;

public class BatchSetMeshCollider : MonoBehaviour
{
    void Start()
    {
        // 获取场景中所有的游戏对象
        GameObject[] objects = GameObject.FindObjectsOfType<GameObject>();

        // 遍历所有游戏对象
        foreach (GameObject obj in objects)
        {
            // 如果游戏对象没有 Mesh Collider 组件，则添加一个
            if (obj.GetComponent<MeshCollider>() == null)
            {
                obj.AddComponent<MeshCollider>();
            }
        }
    }
}
