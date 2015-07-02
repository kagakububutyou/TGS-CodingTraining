using UnityEngine;
using System.Collections;

public class MoveHomingBullets : MonoBehaviour {


    [SerializeField]
    private GameObject target = null;

    [SerializeField]
    private float travelTime = 0.0f;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        MoveBullets();
	}

    /// <summary>
    /// gameObjectをtravelTime秒かけてreachingPointに移動
    /// </summary>
    private void MoveBullets()
    {
        iTween.MoveTo(gameObject, target.transform.position, travelTime);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Target")
        {
            Destroy(gameObject);
        }
    }
}
