using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/// <summary>
/// �˼ƭp��
/// �åB���� �Y��Ʊ�
/// �Ҧp : ���}�C�� ���s�C�� ��ܿ��
/// </summary>
public class CountdownAndDoSomething : MonoBehaviour
{
    #region ���P�ݩ�
    [Header("�˼Ʈɶ�"), Range(1, 5)]
    public float timeCountDown = 3;
    [Header("�˼ƫ�ƥ�")]
    public UnityEvent onTimeUp;
    [Header("����")]
    public Image imageBar;

    private float timeMax;
    private float timer;
    /// <summary>
    /// �}�l�˼� : true �}�l , false ����
    /// Unity Event �i�H�s��
    /// 1.���骫��s�����󤺪�API
    /// 2.�s����k�ȭ� : �L�Ϊ̤@�ӰѼ� �A�������������(������)
    /// 3.�s�����}�ݩ� : �������������(������)
    /// </summary>
    public bool startCountDowm { get; set; }
    #endregion
    #region �˼ƥ\��
    // ����ƥ� : �b Start �e����@��
    private void Awake()
    {
        timeMax = timeCountDown;
    }

    private void Update()
    {
        CountDown();
    }

    /// <summary>
    /// �p�ɾ�
    /// </summary>
    private void CountDown()
    {
        if (startCountDowm)                   //�p�G �}�l �˼�
        {
            if (timer < timeCountDown)        //�p�G �p�ɾ� �p�� �˼Ʈɶ�
            {
                timer += Time.deltaTime;      //�֥[�ɶ� (�� Update ���I�s)
            }
            else
            {
                onTimeUp.Invoke();            //�_�h �p�ɾ� �j�󵥩� �˼Ʈɶ� �N �I�s�ƥ�
            }
            imageBar.fillAmount = timer / timeMax;   //���� =  ��e�ɶ� / �̤j�ɶ�
        }
        else                                  //�_�h �S���ݵ۫��s �N����
        {
            timer = 0;                        //�p�ɾ��k�s
            imageBar.fillAmount = 0;          //�����k�s
        }                        
    }
    #endregion
}
