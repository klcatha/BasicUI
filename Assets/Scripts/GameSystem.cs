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

	bool isFlipPlayerImage;
	public bool IsFlipPlayerImage
	{
		set
		{
			isFlipPlayerImage = value;
			UpdatePlayerImageScale();
		}
	}

	float playerImageScale = 1.0f;
	public void ChangePlayerImageScale(float scale)
	{
		playerImageScale = scale;
		UpdatePlayerImageScale();
	}

	void UpdatePlayerImageScale()
	{
		Vector3 scale = Vector3.one * (playerImageScale * 0.4f + 0.6f);
		if (isFlipPlayerImage) scale.x *= -1.0f;
		playerImage.transform.localScale = scale;
	}

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
