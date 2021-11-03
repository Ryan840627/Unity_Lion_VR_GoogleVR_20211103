using UnityEngine;
using UnityEngine.Events;   //�ޥ� �ƥ� �R�W�Ŷ�

/// <summary>
///VR���ʪ���
///1.VR�`���I�ݨ즹���� Enter
///2.VR�`���I�ݨ�����}������ Exit
///3.VR�`���I�즹������I�郎�ʫ��s Click
/// </summary>
public class VRInerationObject : MonoBehaviour
{
    // Unity �ƥ�Ϊk
    // 1.�ޥ� Events �R�W�Ŷ�
    // 2.�w�q Unity Event ����������]�w���}
    // 3.�Q�n���榹�ƥ󤺮e���a��I�s �ƥ�.Invoke()
    // 4.�ݩʭ��O�]�w�ƥ󤺮e
    [Header("�ƥ� : �ݨ�B���}�P�I��")]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;

    /// <summary>
    /// 1.VR�`���I�ݨ즹���� Enter
    /// </summary>
    public void OnPointerEnter()
    {
        onEnter.Invoke();  //�����ݩʭ��O����OnClick�̭����e
    }
    /// <summary>
    /// VR�`���I�ݨ�����}������ Exit
    /// </summary>
    public void OnPointerExit()
    {
        onExit.Invoke();
    }
    /// <summary>
    /// VR�`���I�즹������I�郎�ʫ��s Click
    /// </summary>
    public void OnPointerClick()
    {
        onClick.Invoke();
    }
}
