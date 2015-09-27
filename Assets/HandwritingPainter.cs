//HandrwritingPainter.cs

using UnityEngine;
using System.Collections;

public class HandwritingPainter : MonoBehaviour
{
	public GameObject spriteContainer;
	public Camera canvasCamera;
	public RenderTexture canvasTexture;
	public Material baseMaterial;
	public Color spriteColor;

	public GameObject pencil;
	public MouseListener pencilListener;

	int spriteCounter = 0;
	int maxSpriteCount = 1000;

	public bool saving;

	void Start()
	{
		pencilListener = pencil.GetComponent<MouseListener>();
	}

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			writeOnPaper(pencilListener.getScreenCoords());
		}
	}

	void writeOnPaper(Vector2 uvPos)
	{
		if (saving) {return;}
		GameObject spriteObj;
		spriteObj = (GameObject)Instantiate(Resources.Load("Sprites/PencilSpriteObject"));
		spriteObj.GetComponent<SpriteRenderer>().color = spriteColor;
		spriteObj.transform.parent = spriteContainer.transform;
		spriteObj.transform.localScale = new Vector3(0.1f, 0.1f, 1f);
		Vector2 spritePos = Vector2.zero;
		spritePos.x = uvPos.x - canvasCamera.orthographicSize;
		spritePos.y = uvPos.y - canvasCamera.orthographicSize;
		spriteObj.transform.localPosition = spritePos;

		spriteCounter++;

		/*
		if (spriteCounter >= maxSpriteCount)
		{
			saving = true;
			Invoke("SaveTexture",0.1f);
		}
		*/
	}

	void SaveTexture()
	{
		spriteCounter = 0;
		RenderTexture.active = canvasTexture;
		Texture2D tex = new Texture2D(canvasTexture.width, canvasTexture.height, TextureFormat.RGB24, false);
		tex.ReadPixels(new Rect(0,0,canvasTexture.width, canvasTexture.height), 0, 0);
		tex.Apply();
		RenderTexture.active = null;
		baseMaterial.mainTexture = tex;
		foreach (Transform child in spriteContainer.transform)
		{
			Destroy(child.gameObject);
		}

		Invoke("finishSaving", 0.1f);
	}

	void finishSaving()
	{
		saving = false;
	}
}