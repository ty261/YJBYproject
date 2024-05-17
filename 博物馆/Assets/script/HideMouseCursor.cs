using UnityEngine;

public class HideMouseCursor : MonoBehaviour
{
    void Start()
    {
        // 隐藏鼠标光标
        Cursor.visible = false;
    }

    void Update()
    {
        // 如果需要在运行时恢复鼠标光标，可以使用下面的代码：
        // Cursor.visible = true;

        // 或者你可以按下 ESC 键来恢复鼠标光标并退出游戏：
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Application.Quit();
        }
    }
}
