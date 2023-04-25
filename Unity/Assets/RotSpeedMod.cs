using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotSpeedMod : MonoBehaviour
{
 public RotateMe rotateMe;
 public Slider slider;

 private void Update()
 {
  rotateMe.speed = slider.value;
 }
}
