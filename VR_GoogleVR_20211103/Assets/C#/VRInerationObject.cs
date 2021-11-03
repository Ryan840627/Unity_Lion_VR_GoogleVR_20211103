using UnityEngine;
using UnityEngine.Events;   //引用 事件 命名空間

/// <summary>
///VR互動物件
///1.VR注視點看到此物件 Enter
///2.VR注視點看到後離開此物件 Exit
///3.VR注視點到此物件並點選互動按鈕 Click
/// </summary>
public class VRInerationObject : MonoBehaviour
{
    // Unity 事件用法
    // 1.引用 Events 命名空間
    // 2.定義 Unity Event 類型欄位應設定公開
    // 3.想要執行此事件內容的地方呼叫 事件.Invoke()
    // 4.屬性面板設定事件內容
    [Header("事件 : 看到、離開與點擊")]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    /// <summary>
    /// 1.VR注視點看到此物件 Enter
    /// </summary>
    public void OnPointerEnter()
    {
        onEnter.Invoke();  //執行屬性面板中的OnClick裡面內容
    }
    /// <summary>
    /// VR注視點看到後離開此物件 Exit
    /// </summary>
    public void OnPointerExit()
    {
        onExit.Invoke();
    }
    /// <summary>
    /// VR注視點到此物件並點選互動按鈕 Click
    /// </summary>
    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
