using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    int playerHP;
    

    private void Start()
    {
        playerHP = 3;        
    }

    private void Update()
    {
        
    }


    //　コライダのIsTriggerのチェックを入れ物理的な衝突をしない（突き抜ける）場合
    void OnTriggerEnter(Collider col) {
        Debug.Log("hit something");
		if(col.tag == "Enemy") {
            playerHP -= 1;
            if (playerHP < 1)
            {
                Destroy(this.gameObject);  //Erase Player

            }
            Debug.Log(playerHP);

        }
	}

}
