using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
	private int Point = 0;

	[SerializeField] private Text pointText;

	[SerializeField] private AudioSource CollectionAudioSource;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("CollectItem"))
		{
			CollectionAudioSource.Play(); 
			Destroy(collision.gameObject);
			Point++;
			pointText.text = "Point: " + Point;
		}
	}
}
