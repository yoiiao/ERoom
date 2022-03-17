using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBoard : MonoBehaviour
{
    public GameObject Hint1;


    // Start is called before the first frame update
    void Start()
    {
        Hint1.SetActive(false);

        // btnHint.onClick.AddListener(ShowHint);

    }

    void ShowHint()
    {
        Hint1.SetActive(true);
        // Invoke("HideHint", 10);

        //Hint.onClick.AddListener(HideHint);
    }

    void HideHint()
    {
        Hint1.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {


    }



    void OnMouseDown()
    {
        ShowHint();
    }


}

