using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotationbody : MonoBehaviour
{
    public GameObject secondcam;
    public GameObject maincam;
  public GameObject button;
    public Vector3 pos;
    public Vector3 rot;

    public Vector3 scal;

   public bool flag = false;
    public bool vflag = false;

    public GameObject bodty;
    public Slider pslider;
    Material bedcolor;
    public GameObject togglecontroller;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        vflag = false;
        bedcolor = bodty.GetComponent<Renderer>().material;
        bodty.transform.GetChild(0).gameObject.SetActive(false);
        bedcolor.color = new Color(200, 241, 0);
        
    }    // Update is called once per frame
    public void goback()
    {
       maincam.SetActive(true);
        secondcam.SetActive(false);
         bodty.tag = "Player";
        bodty.transform.position = GameObject.Find("Togglecontroller").GetComponent<bedbehaviour>().bedposprev;
        bodty.transform.localScale = GameObject.Find("Togglecontroller").GetComponent<bedbehaviour>().bedscale;

        bodty.transform.rotation = GameObject.Find("Togglecontroller").GetComponent<bedbehaviour>().bedrot;
        bodty.transform.GetChild(0).gameObject.SetActive(false);
        bodty.transform.GetChild(2).gameObject.SetActive(false);

    }
    public void buttonforvitals()
    {

        if (vflag)
        {
            vflag = false;
        }
        else
        {
            vflag = true;
        }
    }
    public void buttonforbody()
    {
        
        if(flag)
        {
            flag = false;
        }
        else
        {
            flag = true;
        }
    }
      void bedkacolor()
    {
        if(pslider.value==0)
        {
            bedcolor.color = Color.green;
            bodty.GetComponent<Renderer>().material.color= Color.green;
        }
        else if(pslider.value==1)
        {
            bedcolor.color = Color.yellow;
            bodty.GetComponent<Renderer>().material.color= Color.yellow;
        }
        else
        {
            bedcolor.color = Color.red;
            bodty.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    void Update()
    {  
         bodty = GameObject.FindGameObjectWithTag("Finish");
        //print(bodty.name);
        bedcolor = bodty.GetComponent<Renderer>().material;
        bodty.transform.GetChild(2).gameObject.SetActive(true);
        
  

        //print(bedcolor);
         if (flag ==true)
        {
            bodty.transform.GetChild(0).gameObject.transform.Rotate(0f, 0.4f, 0f);
            bodty.transform.GetChild(0).gameObject.SetActive(true);

        }

        else 
        {
            bodty.transform.GetChild(0).gameObject.SetActive(false);
        }
      
        bedkacolor();

    }
}
