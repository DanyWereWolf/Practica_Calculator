using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    [Header("�������")]
    [SerializeField] private GameObject fierstScreen;
    [SerializeField] private GameObject secondScreen;

    private GameObject _currentScreen;

    [Header("���� �����")]
    [SerializeField] public InputField inputField_1;
    [SerializeField] public InputField inputField_2;

    [Header("�����")]
    [SerializeField] public Text Result_text;
    [SerializeField] public Text Symbol;

    [Header("�����")]
    [SerializeField] public float value_1;
    [SerializeField] public float value_2;
    [SerializeField] public float Result_;


    private void Start()
    {
        fierstScreen.SetActive(true);
        _currentScreen = fierstScreen;
    }
    //---������ �� ����� 4.11
    public void ChangeState(GameObject state)
    {
        if(_currentScreen != null)
        {
            _currentScreen.SetActive(false);
            state.SetActive(true);
            _currentScreen = state;
        }
        
    }
    public void Update()
    {
        float.TryParse(inputField_1.text, out float result);
        value_1 = result;
        float.TryParse(inputField_2.text, out float result_2);
        value_2 = result_2;
    }
    //��������
    public void on�lickPlus()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";           
        }
        else
        {
            Symbol.text = "+";
            Result_ = value_1 += value_2;
            Result_text.text = Result_.ToString();
        }
    }
    //���������
    public void on�lickMinus()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";
        }
        else
        {
            Symbol.text = "-";
            Result_ = value_1 -= value_2;
            Result_text.text = Result_.ToString();
        }

    }
    //���������
    public void on�lickMultiply()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";
        }
        else
        {
            Symbol.text = "*";
            Result_ = value_1 *= value_2;
            Result_text.text = Result_.ToString();
        }

    }
    //�������
    public void on�lickShare()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";
        }
        else
        {
            Symbol.text = "/";
            Result_ = value_1 /= value_2;
            Result_text.text = Result_.ToString();
        }

    }

}
