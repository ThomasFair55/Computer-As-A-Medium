using UnityEngine;
using TMPro;

public class Mana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana; 
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;
    }
}

