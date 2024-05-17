using UnityEngine;

public class BatchSetMeshCollider : MonoBehaviour
{
    void Start()
    {
        // ��ȡ���������е���Ϸ����
        GameObject[] objects = GameObject.FindObjectsOfType<GameObject>();

        // ����������Ϸ����
        foreach (GameObject obj in objects)
        {
            // �����Ϸ����û�� Mesh Collider ����������һ��
            if (obj.GetComponent<MeshCollider>() == null)
            {
                obj.AddComponent<MeshCollider>();
            }
        }
    }
}
