using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    [SerializeField] private Transform _pointer;
    [SerializeField] private Selectable _currentSelectable;


    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            _pointer.position = hit.point;

            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if(selectable)
            {
                if(_currentSelectable && _currentSelectable != selectable)
                {
                    _currentSelectable.Deselect();
                }
                _currentSelectable = selectable;
                selectable.Select();
            } else
            {
                if(_currentSelectable)
                {
                    _currentSelectable.Deselect();
                    _currentSelectable = null;
                }
            }
        } else
        {
            if(_currentSelectable)
            {
                _currentSelectable.Deselect();
                _currentSelectable = null;
            }
        }
        

    }

}
