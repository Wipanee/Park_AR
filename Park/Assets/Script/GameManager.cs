using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject park;
    public float value;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveLeft()
    {
        value -= 5.5f;
        park.transform.eulerAngles = new Vector3(0, value, 0);
    }

    public void MoveRight()
    {
        value += 5.5f;
        park.transform.eulerAngles = new Vector3(0, value, 0);
    }

    public void BoatView()
    {
        //cameras[0].enabled = false;
       // cameras[1].enabled = false;
       // cameras[2].enabled = true;
    }

    public void gotoLayout1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
