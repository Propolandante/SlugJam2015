//PaperController.cs

using UnityEngine;
using System.Collections.Generic;
using System.Linq;

class PaperController : MonoBehaviour
{
	public List<GameObject> papers = new List<GameObject>();
	public GameObject currentPaper;
	public GameObject paperTarget;
	public GameObject oldPaper;
	public Material rtMat;
	public Material staticMat;

	public GameObject playerHand;
	public GameObject aiHand;

	bool cycling;
	bool toTarget;

	private float cycleDuration = .75f;
	private float timeStartedCycling;

	void Update()
	{
		if (cycling)
		{
			handlePaperCycle();
		}
	}

	public void nextPage()
	{

		if(cycling) {return;}
		
		timeStartedCycling = Time.time;

		// send front paper to back
		papers.Add(papers.First());
		papers.RemoveAt(0);

		//printYValues();


		currentPaper = papers.First();
		oldPaper = papers.Last();

		playerHand.GetComponent<MouseListener>().paper = currentPaper;
		aiHand.GetComponent<AIBehavior>().paper = currentPaper;

		cycling = true;
		toTarget = true;
	}

	private void handlePaperCycle()
	{
		if (toTarget)
		{
			float progress = (Time.time - timeStartedCycling) / (cycleDuration / 2);
			Vector3 startPos = Vector3.zero;
			Vector3 newPos = Vector3.Lerp(startPos, paperTarget.transform.localPosition, progress);
			oldPaper.transform.localPosition = newPos;

			if (progress >= 1.0f)
			{
				toTarget = false;
				shiftYValues();
				//printYValues();
			}
		}
		else
		{
			float progress = (Time.time - timeStartedCycling - (cycleDuration / 2)) / (cycleDuration / 2);
			Vector3 endPos = new Vector3(0, -.02f, 0);
			Vector3 newPos = Vector3.Lerp(paperTarget.transform.localPosition, endPos, progress);
			oldPaper.transform.localPosition = newPos;

			if (progress >= 1.0f)
			{
				finishCycling();
				//printYValues();
			}
		}
	}

	private void finishCycling()
	{
		cycling = false;
		GameObject.Find("TexturePainter").GetComponent<HandwritingPainter>().clearCanvas();
		currentPaper.GetComponent<MeshRenderer>().material = rtMat;
		oldPaper.GetComponent<MeshRenderer>().material = staticMat;
	}

	private void shiftYValues()
	{
		for (int p = 0; p < papers.Count; p++)
		{
			Vector3 pos = papers[p].transform.localPosition;
			pos.y = (p * -.01f);
			papers[p].transform.localPosition = pos;
		}
	}

	private void printYValues()
	{
		string outString = "Pages:\n";
		for (int p = 0; p < papers.Count; p++)
		{
			outString += "\t" + papers[p].name + ": " + papers[p].transform.localPosition.y;
		}

		Debug.Log(outString);
	}
}
