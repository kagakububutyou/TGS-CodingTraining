using UnityEngine;
using System.Collections;

public class MoveNormalBullets : MonoBehaviour {

    [SerializeField]
    private Vector3 reachingPoint = new Vector3(0,0,0);
    [SerializeField]
    private float travelTime = 0.0f;

	// Use this for initialization
	void Start () 
    {
        MoveBullets();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    /// <summary>
    /// gameObjectをtravelTime秒かけてreachingPointに移動
    /// </summary>
    private void MoveBullets()
    {
        iTween.MoveTo(gameObject, reachingPoint, travelTime);
    }
}
