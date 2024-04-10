using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static BuildManager instance;

    void Awake()
    {
        if (instance!= null)
        {
            Debug.LogError("More Than on Manager in scene!");
            return;
        }
        instance = this;
    }
    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;
    private Node selectedNode;
    public NodeUI nodeUI;

    // public GameObject GetTurretToBuild ()
    // {
    //     return turretToBuild;
    // }

    // public void SetTurretToBuild(GameObject turret)
    // {
    //     turretToBuild = turret;
    // }
    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void SelectNode(Node node)
    {
        if(selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }
    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }
    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
