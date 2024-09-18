using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] int myIntelligence;
    [SerializeField] int myStrength;
    [SerializeField] int myWisdom;
    [SerializeField] int myDexterity;

    [SerializeField] Slider myDexSlider;

    [SerializeField] GameObject myPanel;
    [SerializeField] Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.dexterity = 50;
        PlayerStats.strength = 10;
        PlayerStats.wisdom = 2;
        PlayerStats.intelligence = 14;

        myDexterity = PlayerStats.dexterity;
        myIntelligence = PlayerStats.intelligence;
        myStrength = PlayerStats.strength;
        myWisdom = PlayerStats.wisdom;

        myDexSlider.value = myDexterity;

        myAnimator = myPanel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DexSliderChange(float value)
    {
        myDexterity = (int)value;
        PlayerStats.dexterity = (int)value;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("InfoScreen");
    }
    public void MovePanel()
    {
        myAnimator.SetBool("Move", true);
    }
}

public static class PlayerStats
{
    public static int strength;
    public static int dexterity;
    public static int wisdom;
    public static int intelligence;
}
