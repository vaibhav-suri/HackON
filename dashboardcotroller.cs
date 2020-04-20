using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashboardcotroller : MonoBehaviour
{
    public GameObject maindb;
    public GameObject perdb;
    public GameObject maincam;
    public GameObject secondcam;
    bool pflag = false;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        maindb.SetActive(true);
        perdb.SetActive(false);
    }
    public void  buttontime()
    {
        if(pflag)
        {
            pflag = false;
        }
        else
        {
            pflag = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
     if(maincam.activeInHierarchy && !secondcam.activeInHierarchy)
        {
            maindb.SetActive(true);
            perdb.SetActive(false);

            if(pflag)
            {
                panel.SetActive(true);
            }
            else
            {
                panel.SetActive(false);
            }
        }
        else if (!maincam.activeInHierarchy && secondcam.activeInHierarchy)
        {
            perdb.SetActive(true);
            maindb.SetActive(false);

        }


    }
}
