using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Shape : MonoBehaviour
{
    protected string ShapeName { get; set; }
    protected Color ShapeColor { get; set; }

    [SerializeField] protected GameObject infoPanel;
    protected TextMeshProUGUI infoText;

    public bool Selected { get; set; }

    [SerializeField] GameManager gameManager;

    private Color defaultColor;
    private Vector3 defaultPosition;
    private Quaternion defaultRotation;

    // Start is called before the first frame update
    void Awake()
    {
        infoText = infoPanel.GetComponentInChildren<TextMeshProUGUI>();
        defaultColor = GetComponent<Renderer>().material.color;
        defaultPosition = transform.position;
        defaultRotation = transform.rotation;
    }


    // Update is called once per frame
    void Update()
    {
        if (Selected)
        {
            TransformShape();
        }
    }

    public virtual void SelectShape()
    {
        gameManager.DeselectShapes();
        Selected = true;
    }

    public void ResetShape()
    {
        GetComponent<Renderer>().material.color = defaultColor;
        transform.position = defaultPosition;
        transform.rotation = defaultRotation;
    }

    public abstract void TransformShape();

    public void DisplayText()
    {
        infoText.text = ShapeName;
        infoPanel.SetActive(true);
    }

    public void HideText()
    {
        infoPanel.SetActive(false);

    }
}
