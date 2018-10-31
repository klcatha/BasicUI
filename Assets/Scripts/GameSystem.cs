using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

	public void Reset()
	{
		SceneManager.LoadScene(0);
	}

	public void Submit()
	{
		Debug.Log("Player Name: " + nameField.text);
		Debug.Log("Player Type: " + playerType.ToString());
		Debug.Log("Main Image Scale: " + playerImage.transform.localScale);
	}

	public void ChangePlayerType(int index)
	{
		ChangePlayerType ((PlayerType)index);
	}

	public void ChangePlayerType(PlayerType type)
	{
		if (playerType == type) return;

		playerType = type;
		switch (type)
		{
			case PlayerType.Monster:
				playerImage.sprite = monsterSprite;
				break;
			case PlayerType.Merman:
				playerImage.sprite = mermanSprite;
				break;
			case PlayerType.Robot:
				playerImage.sprite = robotSprite;
				break;
			default:
				break;
		}
		playerImage.SetNativeSize();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
