using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button myButton; 
    public YunaEnemy enemy;   

    private void Start()
    {
        myButton.onClick.AddListener(() => enemy.TakeDamage(10));
    }
}

