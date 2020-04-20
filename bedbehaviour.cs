using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedbehaviour : MonoBehaviour
{
    int count = 0;
    public GameObject rotbutton;
    public GameObject secondcam;
    public Vector3 bedposprev;
    public Quaternion bedrot;
    public Vector3 bedscale;
    public GameObject currentbed;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.gameObject.SetActive(true);
        secondcam.SetActive(false);
    //    rotbutton.SetActive(false);
    }
    public void getcord(string bed)
    {
         bedposprev = GameObject.Find(bed).transform.localPosition;
         bedrot = GameObject.Find(bed).transform.rotation;
         bedscale = GameObject.Find(bed).transform.localScale;
        
        print(bedrot);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        { 
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit))
            {
                string bed = hit.collider.name;

                count = count + 1;

                if (count==1)
                {
                    GameObject.Find(hit.collider.name);
                    getcord(bed);
                    print(bed);
                   
                }
                else if (count == 2)
                {
                      Camera.main.gameObject.SetActive(false);
                    secondcam.SetActive(true);
                    count = 0;
                    print(bed);
                    var pbed = GameObject.Find(bed);
                    pbed.transform.position = new Vector3(-1.13f, -5.71f, -17.2f);
                 pbed.transform.eulerAngles = new Vector3(-90f, 0f, 172.2f);
                    pbed.tag = "Finish";
                }
            }
        }
    }
}
