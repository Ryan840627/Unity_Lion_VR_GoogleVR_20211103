using UnityEngine;

/// <summary>
/// 遊戲管理器
/// 離開遊戲、重新遊戲等等...
/// </summary>
public class GM : MonoBehaviour
{
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
