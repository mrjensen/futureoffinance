using UnityEngine;
using System.Collections;
// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {
	private Vector3 startingPosition;
	private int someInt = 1;
	private int accountValue = 2500;
	private string accountText = "Balance: ";
	private Vector3 oriSize;


	void Start() {
	}

	void LateUpdate() {
		int randResult = Random.Range (0, 200);
		if (someInt == randResult) {
			int calcResult = accountValue + Random.Range(-500, 550);
			GetComponent<TextMesh>().text = accountText + calcResult + " kr.";
		}
	}
}
