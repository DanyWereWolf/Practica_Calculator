using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    
    [SerializeField] private GameObject fierstScreen;
    [SerializeField] private GameObject secondScreen;

    private GameObject currentScreen;

    public InputField inputField_1;
    public InputField inputField_2;
    public float Result_22;
    public Text Result_text;
    public Text Symbol;

    public float value_1;
    public float value_2;
    

    private void Start()
    {
        fierstScreen.SetActive(true);
        currentScreen = fierstScreen;
      
        
    }

    //---������ �� ����� 4.11
    public void ChangeState(GameObject state)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
        
    }
    //------------------------
    public void Update()
    {
        float.TryParse(inputField_1.text, out float result);
        value_1 = result;
        float.TryParse(inputField_2.text, out float result_2);
        value_2 = result_2;
    }
    public void on�lickPlus()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";           
        }
        else
        {
            Symbol.text = "+";
            Result_22 = value_1 += value_2;
            Result_text.text = Result_22.ToString();

        }
        
    }
    public void on�lickMinus()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";
        }
        else
        {
            Symbol.text = "-";
            Result_22 = value_1 -= value_2;
            Result_text.text = Result_22.ToString();

        }

    }
    public void on�lickMultiply()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";
        }
        else
        {
            Symbol.text = "*";
            Result_22 = value_1 *= value_2;
            Result_text.text = Result_22.ToString();

        }

    }
    public void on�lickShare()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "������� �����!";
        }
        else
        {
            Symbol.text = "/";
            Result_22 = value_1 /= value_2;
            Result_text.text = Result_22.ToString();

        }

    }

}
