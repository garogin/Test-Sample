using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public float Size;

	// Use this for initialization
	void Awake () {
		// gameObject.GetComponent<RectTransform>() でプログラム側からコンポーネントを取得できる
		RectTransform rect = gameObject.GetComponent<RectTransform>(); 
		Size = rect.sizeDelta.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += (Vector3.down * 10);
		// 画面外へいったら削除
		// 画面の中心がゼロなのでマイナス画面サイズ÷２が画面の下の座標となる。
		// ※コインのサイズを考慮しないとコインの中心が画面の下にふれた時点で消滅してしまう。
		if (transform.localPosition.y + Size < -(Screen.height / 2)) { 
			Destroy(gameObject);
		}
	}
}
