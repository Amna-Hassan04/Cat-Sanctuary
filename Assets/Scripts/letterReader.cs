using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterReader : MonoBehaviour
{
    [Header("Raycast Features")]
    [SerializeField] private float rayLength = 5;
    private Camera _camera;

    [Header("Crosshair")]
    [SerializeField] private Image crosshair;

    [Header("Input Key")]
    [SerializeField] private KeyCode interactKey;

    private NoteController _noteController;

    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Physics.Raycast(_camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f)), transform.forward, out RaycastHit hit, rayLength))
        {
            var readableItem = hit.collider.GetComponent<NoteController>();
            if(readableItem != null)
            {
                _noteController = readableItem;
                HighlightCrosshair(true);
                
            }
            else
            {
                ClearNote();
            }
        }
        else
        {
                ClearNote();
        }

        if(_noteController != null)
        {
            if(Input.GetKeyDown(interactKey))
            {
                _noteController.ShowNote();
            }
        }
    }

     void ClearNote()
     {
        if(_noteController != null)
        {
            HighlightCrosshair(false);
            _noteController = null;
        }
     }

     void HighlightCrosshair(bool on)
     {
        if(on)
        {
            crosshair.color = Color.red;
        }
        else{
            crosshair.color = Color.white;
        }
     }


}