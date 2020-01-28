using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angle : MonoBehaviour {
    public GameObject target;
    public float fov = 20.0f;
    public Material CanSee;
    public Material CannotSee;
    public float ang;
    public float distancesquared;
	
	// Update is called once per frame
	void Update () {
        Vector3 targetdir = target.transform.position - transform.position;
        distancesquared = targetdir.sqrMagnitude;
        ang = Vector3.Angle(targetdir, transform.forward);
        if (ang < fov && distancesquared < 100)
        {
            target.GetComponent<Renderer>().material = CanSee;
        }
        else
        {
            target.GetComponent<Renderer>().material = CannotSee;
        }
    }

    private void OnDrawGizmos()
    {
        // we want to draw a line along FOV
        Vector3 f = transform.forward*10;
        Vector3 f1 = Quaternion.AngleAxis(fov, Vector3.up) * f;
        Vector3 f2 = Quaternion.AngleAxis(-fov, Vector3.up) * f;
        Vector3 f3 = Quaternion.AngleAxis(fov, Vector3.right) * f;
        Vector3 f4 = Quaternion.AngleAxis(-fov, Vector3.right) * f;
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, f);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, f1);
        Gizmos.DrawRay(transform.position, f2);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, f3);
        Gizmos.DrawRay(transform.position, f4);


    }
}
