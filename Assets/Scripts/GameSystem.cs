using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour {

	[SerializeField]
	private InputField nameField;
	[SerializeField]
	private Image playerImage;
	[SerializeField]
	private Slider playerImageScaleSlider;

	[SerializeField]
	private Sprite monsterSprite;
	[SerializeField]
	private Sprite mermanSprite;
	[SerializeField]
	private Sprite robotSprite;

	public enum PlayerType
	{
		Monster,
		Merman,
		Robot
	}

	//デフォルトはモンスター
	PlayerType playerType = PlayerType.Monster;

	public void Back()
	{
		Debug.Log("Back");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
