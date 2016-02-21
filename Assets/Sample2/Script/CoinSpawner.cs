using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour {

	public GameObject Coin;
	public Transform Container;

	public void Spawn() {
		GameObject coin = Instantiate<GameObject>(Coin);
		coin.transform.SetParent(Container);
		coin.transform.localPosition = new Vector3(Random.Range(-50, 50), 0, 0);
	}
}
