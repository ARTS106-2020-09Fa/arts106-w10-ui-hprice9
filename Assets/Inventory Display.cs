using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    typeIndex = Random.Range(0, 3);
buttonText = GetComponentInChildren<Text>();
buttonText.text = itemTypes[typeIndex];
    {
        
    }
}
