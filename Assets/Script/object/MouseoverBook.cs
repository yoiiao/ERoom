using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MouseoverBook : MonoBehaviour
{

    public GameObject pass;
    // Start is called before the first frame update
    void Start()
    {
        pass.SetActive(false);
    }
    void ShowIPF()
    {
        pass.SetActive(true);
        // Invoke("HideHint", 10);

        //Hint.onClick.AddListener(HideHint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnMouseEnter()
    {
        Vector3 vec = new Vector3(0, 0, 0.1f);
        transform.Translate(vec);

    }
    void OnMouseDown()
    {
        ShowIPF();
        

        }
    void OnMouseExit()
    {
        Vector3 uvec = new Vector3(0, 0, -0.1f);
        transform.Translate(uvec);
    }

   // public void GetButtonName()
//{ // 버튼 이름 가져오기
     // string ButtonName = EventSystem.current.currentSelectedGameObject.name; 
      //  Debug.Log(ButtonName);
  //  }



}
