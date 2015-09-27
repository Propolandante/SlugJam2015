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
	public GameObject canvas;

	public Texture2D bakedTex;
	public Texture exampleTex;

	public GameObject pencil;
	public MouseListener pencilListener;
	public AIBehavior ai_behavior;

	public int spriteCounter = 0;
	int maxSpriteCount = 1000;

	public float spriteWidth = 0.004f;

	float lineDensity = 1.0f;

	public bool saving;

	void Start()
	{
		pencilListener = pencil.GetComponent<MouseListener>();
	}

	public void writeDot(Vector2 pos)
	{
		drawSprite(pos);
	}

	public void writeLine(Vector2 prevPos, Vector2 curPos)
	{
		if (prevPos == curPos)
		{
			return;
		}

		float dist = Vector2.Distance(prevPos, curPos);
		int numSprites = 1 + Mathf.CeilToInt(dist / spriteWidth);
		//Debug.Log("numSprites: " + numSprites);

		for (int s = 0; s < numSprites; s++)
		{
			float posAcrossLine = (float) s / (numSprites - 1);
			//Debug.Log("s: " + s + ", posAcrossLine: " + posAcrossLine);
			Vector2 linePos = Vector2.Lerp(prevPos, curPos, posAcrossLine);
			drawSprite(linePos);
		}



	}

	private void drawSprite(Vector2 pos)
	{
		// Tell the AI not to write here anymore
		if(pencilListener.over_margin(pos)) {
			int i = (int) Mathf.Floor((1-pos.y)*AIBehavior.RESOLUTION);
			ai_behavior.available_space[i] = true;
		}

		GameObject spriteObj;
		spriteObj = (GameObject)Instantiate(Resources.Load("Sprites/PencilSpriteObject"));
		spriteObj.GetComponent<SpriteRenderer>().color = spriteColor;
		spriteObj.transform.parent = spriteContainer.transform;
		Vector2 spritePos = Vector2.zero;
		spritePos.x = pos.x - canvasCamera.orthographicSize;
		spritePos.y = pos.y - canvasCamera.orthographicSize;
		spriteObj.transform.localPosition = spritePos;

		spriteCounter++;
	}

	public void SaveTexture()
	{
		Debug.Log("SaveTexture()");
		saving = true;
		spriteCounter = 0;
		System.DateTime date = System.DateTime.Now; // pretty sure this is unnecessary
		RenderTexture.active = canvasTexture;
		bakedTex = new Texture2D(canvasTexture.width, canvasTexture.height, TextureFormat.RGB24, false);
		bakedTex.ReadPixels(new Rect(0,0,canvasTexture.width, canvasTexture.height), 0, 0);
		bakedTex.Apply();
		RenderTexture.active = null;
		canvas.GetComponent<MeshRenderer>().material.SetTexture("_MainTex",bakedTex);
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
