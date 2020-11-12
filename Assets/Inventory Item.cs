using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryItem : MonoBehaviour
    private Text buttonText;
private string[] itemTypes = { "Armor", "Weapon", "Spell" };
public int typeIndex;
typeIndex = Random.Range(0, 3);
buttonText = GetComponentInChildren <Text> ();
buttonText.text = itemTypes[typeIndex];
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
