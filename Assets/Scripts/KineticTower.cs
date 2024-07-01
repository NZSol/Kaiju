using UnityEngine;
using Combat.Tower;

public class KineticTower : MonoBehaviour
{
    //This script will control how the tower attacks.
    //Mesh, range values, etc. are assigned by the scriptableObject



    [SerializeField]
    Tower stats;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    [Range(0,100)]
    int health = 100;
    void Start()
    {
        gameObject.GetComponent<MeshFilter>().mesh = stats.healthyMesh.sharedMesh;
        gameObject.GetComponent<MeshRenderer>().material = stats.healthyMat;
    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case var expression when health > 66:
                gameObject.GetComponent<MeshFilter>().mesh = stats.healthyMesh.sharedMesh;
                gameObject.GetComponent<MeshRenderer>().material = stats.healthyMat;
                break;
            case var expression when health >33 && health < 66:
                gameObject.GetComponent<MeshFilter>().mesh = stats.dmgMesh.sharedMesh;
                gameObject.GetComponent<MeshRenderer>().material = stats.dmgMat;
                break;
            case var expression when health <33:
                gameObject.GetComponent<MeshFilter>().mesh = stats.wreckMesh.sharedMesh;
                gameObject.GetComponent<MeshRenderer>().material = stats.wreckMat;
                break;
        }
    }
}
