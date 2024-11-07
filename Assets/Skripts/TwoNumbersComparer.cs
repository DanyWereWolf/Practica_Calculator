using UnityEngine;
using UnityEngine.UI;
using System;

public class TwoNumbersComparer : MonoBehaviour
{
    [Header("Поля ввода")]
    [SerializeField] public InputField inputField_1;
    [SerializeField] public InputField inputField_2;

    [Header("Текст")]
    [SerializeField] public Text Result_text;
   

    [Header("Числа")]
    [SerializeField] public float value_1;
    [SerializeField] public float value_2;
    
    void Start()
    {
        
    }
    void Update()
    {
        float.TryParse(inputField_1.text, out float result);
        value_1 = result;
        float.TryParse(inputField_2.text, out float result_2);
        value_2 = result_2;
    }

    public void onCheckClick()
    {
        if (value_1 == 0f && value_2 == 0f)
        {
            Result_text.text = "Введите число!";
        }
        else
        {
            if (value_1 == value_2)
            {
                Result_text.text = "Равны";
            }
            else
            {
                Result_text.text = "Не равны";
            }
          
        }
    }
}
