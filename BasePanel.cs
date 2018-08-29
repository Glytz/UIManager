using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BasePanel : MonoBehaviour
{
    bool _isActive = false;
    private void Awake()
    {
        this.gameObject.SetActive(false);
        _isActive = false;
    }
    virtual public void ShowPanel()
    {
        this.gameObject.SetActive(true);
        _isActive = true;
    }
    virtual public void HidePanel()
    {
        this.gameObject.SetActive(false);
        _isActive = false;

    }
    public void TogglePanel()
    {
        if (_isActive)
            this.HidePanel();
        else
            this.ShowPanel();
    }
}
