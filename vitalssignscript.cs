using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class vitalssignscript : MonoBehaviour
{
    public TMP_Text naam;
    public TMP_Text age;
    public TMP_Text weight;
    public TMP_Text height;
    public TMP_Text heartrate;
    public TMP_Text temperature;
    public TMP_Text bp;
    public TMP_Text doctor;
    public TMP_Text diagnosis;
    public GameObject gonemad;
    string[] heartarri = new string[] { "66", "66", "66", "66", "66", "66", "66", "66", "66", "66", "69", "69", "69", "69", "69", "69", "69", "69", "69", "69", "69", "69", "69", "69" };
    // Start is called before the first frame update
    void Start()
    {
     }
    void normalheartrating(TMP_Text heart)
    {
        for (int i = 0; i < heartarri.Length; i++)
        {
            heart.text = "Heart Rate:" + heartarri[i];
            print(  heartarri[i]);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        normalheartrating(heartrate);
    }
}
