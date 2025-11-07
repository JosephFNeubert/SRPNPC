using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
	public Slider _slider;

	private void Start()
	{
		GetComponentInParent<IHealth>().OnHPPctChanged += HandleHPPctChanged;
	}

	private void HandleHPPctChanged(float pct)
	{
		Debug.Log("Hi");
		_slider.value = pct;
	}
}
