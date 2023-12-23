using System;
using UnityEngine;

public class Level 
{
    public event Action Defeat;

    public void Start()
    {
        //Логика старта
        Debug.Log("StartLevel");
    }

    public void Restart()
    {
        //логика очистки уровня
        Debug.Log("Очистка уровня");
        Start();
    }

    public void OnDefeat()
    {
        //логика остановки игры
        Defeat?.Invoke();
    }
}
