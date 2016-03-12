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

[RequireComponent(typeof(Collider))]
public class ObjectFocus : MonoBehaviour {
	private Vector3 startingPosition;
	private Vector3	startingScaling;

	void Start() {
		startingPosition = transform.localPosition;
		startingScaling = transform.localScale;
		SetGazedAt(false);
	}

//	void LateUpdate() {
//		Cardboard.SDK.UpdateState();
//		if (Cardboard.SDK.BackButtonPressed) {
//			Application.Quit();
//		}
//	}

	public void SetGazedAt(bool gazedAt) {
		if (gazedAt) {
			GetComponent<Renderer> ().transform.localScale += new Vector3 (0.5F, 0.5F, 0);
		} else {
			GetComponent<Renderer> ().transform.localScale = startingScaling;
		}
	}

	public void Reset() {
		transform.localPosition = startingPosition;
	}

	public void ToggleVRMode() {
		Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
	}

	public void TeleportRandomly() {
		transform.localScale += new Vector3 (0.5F, 0.5F, 0);
	}

}
