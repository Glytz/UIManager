using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public Canvas UIManagerCanvas;
    private UIManager() { }
    public List<BasePanel> basePanelPrefabList;
    Dictionary<Type, BasePanel> panelMap = new Dictionary<Type, BasePanel>();
    // Use this for initialization
    void Awake()
    {
        foreach (var panelPrefab in basePanelPrefabList)
        {
            if (panelPrefab)
            {
                var panel = Instantiate(panelPrefab, UIManagerCanvas.transform, false);
                panelMap.Add(panel.GetType(), panel);
                panel.HidePanel();
            }
        }
    }

    public BasePanel GetPanel<t>() where t : BasePanel
    {
        return panelMap[typeof(t)];
    }

    public void ShowPanel<t>() where t : BasePanel
    {
        panelMap[typeof(t)].ShowPanel();
    }

    public void HidePanel<t>() where t : BasePanel
    {
        panelMap[typeof(t)].HidePanel();
    }

    public void TogglePanel<t>() where t : BasePanel
    {
        panelMap[typeof(t)].TogglePanel();
    }

    public void HideAllPanels()
    {
        foreach (var panel in panelMap)
        {
            panel.Value.HidePanel();
        }
    }
}
