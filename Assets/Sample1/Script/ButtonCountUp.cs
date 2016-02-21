using UnityEngine;
using UnityEngine.UI; // 2dの物をスクリプトで扱う場合に必要
using System.Collections;

public class ButtonCountUp : MonoBehaviour {

	public int CountNum;
	public Text Counter; // ヒエラルキーからリンクさせておく

	// Awakeは実行時に呼ばれるメソッド
	void Awake() {
		Counter.text = "0"; // Counterの文字を"０"に初期化
		CountNum = 0;
	}

	// ボタンを押すたびにカウントが増える、増やした後の数値がテキストに入る。
	public void CountUpText() {
		CountNum++;
		Counter.text = CountNum.ToString();
	}
}
