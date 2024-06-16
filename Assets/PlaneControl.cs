using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class PlaneControl : MonoBehaviour
{
    public ARPlaneManager planeManager;

    public Material redMaterial;
    public Material greenMaterial;
    public Material blueMaterial;

    public Button redBtn;
    public Button greenBtn;
    public Button blueBtn;
    public GameObject Cube;

    public Text TextMesh;

    private MeshRenderer currentObj;

    private void Start()
    {
        redBtn.onClick.AddListener(UpdateRed);
        greenBtn.onClick.AddListener(UpdateGreen);
        blueBtn.onClick.AddListener(UpdateBlue);
    }

    private bool isRunning = false;

    public void Update()
    {
        if (!planeManager.isActiveAndEnabled && !isRunning)
        {
            Debug.Log("[Test]-> Plane Disable , this runs once ");

            Transform posValue = GameObject.FindGameObjectWithTag("pos").transform;
            GameObject obj = Instantiate(Cube, posValue.position, Quaternion.identity);
            
            if(obj != null)
            {
                TextMesh.text = "Found GameObject";
                currentObj = obj.GetComponent<MeshRenderer>();
            }
            isRunning = true;
        }
    }

    public void UpdateTouches()
    {
        
    }

    private void UpdateRed()
    {
        if(currentObj != null)
        {
            TextMesh.text = "Red Button Pressed";
            currentObj.material = redMaterial;
            
        }
    }

    private void UpdateGreen()
    {
        if(currentObj != null)
        {
            TextMesh.text = "Red Button Pressed";
            currentObj.material = greenMaterial;
        }
    }

    private void UpdateBlue()
    {
        if(currentObj != null)
        {
            TextMesh.text = "Red Button Pressed";
            currentObj.material = blueMaterial;
        }
    }

    private void OnDisable()
    {
        redBtn.onClick.RemoveListener(UpdateRed);
        greenBtn.onClick.RemoveListener(UpdateGreen);
        blueBtn.onClick.RemoveListener(UpdateBlue);
    }
}
