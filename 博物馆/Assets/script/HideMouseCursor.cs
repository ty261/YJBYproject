using UnityEngine;

public class HideMouseCursor : MonoBehaviour
{
    void Start()
    {
        // ���������
        Cursor.visible = false;
    }

    void Update()
    {
        // �����Ҫ������ʱ�ָ�����꣬����ʹ������Ĵ��룺
        // Cursor.visible = true;

        // ��������԰��� ESC �����ָ�����겢�˳���Ϸ��
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Application.Quit();
        }
    }
}
