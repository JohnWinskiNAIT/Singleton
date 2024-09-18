using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetInfo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = PlayerStats.dexterity.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
