using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] protected GameObject infoPanel;
    [SerializeField] protected TextMeshProUGUI welcomeText;

    [SerializeField] protected Shape[] shapes;


    // Start is called before the first frame update
    void Start()
    {
        welcomeText.text =
            "Hello " + PlayerPrefs.GetString("playerName") + ",\r\nSelect your shape";
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                hit.collider.gameObject.GetComponent<Shape>().DisplayText();
                hit.collider.gameObject.GetComponent<Shape>().SelectShape();
            }
            else
            {
                DeselectShapes();
                HideText();
            }
        }
    }

    public void DeselectShapes()
    {
        foreach (Shape s in shapes)
        {
            s.Selected = false;
            s.ResetShape();
        }
    }

    public void HideText()
    {
        infoPanel.SetActive(false);
    }

}
