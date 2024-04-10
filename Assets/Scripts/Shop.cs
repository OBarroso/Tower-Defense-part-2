using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missleLauncher;
    public TurretBlueprint lazerBeamer;
    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissleLauncher()
    {
        Debug.Log("Missle Launcher Selected");
        buildManager.SelectTurretToBuild(missleLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Lazer Beamer Selected");
        buildManager.SelectTurretToBuild(lazerBeamer);
    }
}
