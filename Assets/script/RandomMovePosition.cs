using UnityEngine;
using System.Collections;

public class RandomMovePosition : MonoBehaviour {

    /// <summary>
    /// 範囲の最小値
    /// </summary>
    [SerializeField]
    private Vector3 minimumPosition = new Vector3(0, 0, 0);
    /// <summary>
    /// 範囲の最大値
    /// </summary>
    [SerializeField]
    private Vector3 maximumPosition = new Vector3(0, 0, 0);
    /// <summary>
    /// 移動先の座標
    /// </summary>
    private Vector3 destinationPosition = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// 当たり判定
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "HomingBullets(Clone)")
        {
            MovePosition();
        }
    }
    /// <summary>
    /// 座標をRandomで移動
    /// </summary>
    private void MovePosition()
    {
        destinationPosition.x = UnityEngine.Random.Range(minimumPosition.x, maximumPosition.x);
        destinationPosition.y = UnityEngine.Random.Range(minimumPosition.y, maximumPosition.y);

        transform.position = destinationPosition;
    }
}
