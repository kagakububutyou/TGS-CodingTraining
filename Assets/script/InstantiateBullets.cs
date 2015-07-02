using UnityEngine;
using System.Collections;

public class InstantiateBullets : MonoBehaviour
{

    /// <summary>
    /// 弾
    /// </summary>
    [SerializeField]
    private GameObject normalBullets = null;
    [SerializeField]
    private GameObject homingBullets = null;

	// Use this for initialization
	private void Start () 
    {
        
	}
	
	// Update is called once per frame
	private void Update () 
    {
        ShotBullets();
	}

    /// <summary>
    /// 弾の発射
    /// </summary>
    private void ShotBullets()
    {
        ///  通常弾
        if (Input.GetButtonDown("Shot"))
        {
            Instantiate(normalBullets, transform.position, Quaternion.identity);
        }
        /// 左クリック
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(homingBullets, transform.position, Quaternion.identity);
        }
    }
}
