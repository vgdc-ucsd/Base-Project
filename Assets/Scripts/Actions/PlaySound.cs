using UnityEngine;
using System.Collections;

public class PlaySound : Action {

	// By default, automatically use the AudioSource component
	// already attached to this GameObject, if one exists.
	[SerializeField]
	private bool autoDetectAudioSource = true;

	// Remember to add an AudioSource component to your GameObject,
	// or Unity will not know where this sound is coming from,
	// no sound will play, and you will be a sad game maker. :(
	[SerializeField]
	private AudioSource audioSource;

	// The sound effect you would like to play. If left null, it will simply
	// play whatever audio clip is currently attached to the Audio Source
	[SerializeField]
	private AudioClip audioClip;

	// Volume multiplier, where 0 is silence and 1 is max volume
	[SerializeField] 
	[Range(0.0f, 1.0f)]
	private float volume = 1.0f;

	// If we don't specify an AudioSource in the editor, try to get one
	// from the GameObject this script is attached to.
	void Start() {
		if ( autoDetectAudioSource ) {
			audioSource = GetComponent<AudioSource>();
		}

		if ( audioSource == null ) {
			Debug.LogWarning("PlaySound AudioSource is missing!");
		}
	}

	// In the Action class, we defined a method PerformAction() which is
	// called by many EventComponents when events are detected. We want
	// to override our original definition here so that we can access
	// our audio source and clip data, and perform our own logic.
	override public void PerformAction() {

		// Don't play the sound over itself
		if ( !audioSource.isPlaying ) {
			// If we specified an AudioClip, play that one, otherwise
			// play whatever clip is attached to the AudioSource by default
			if ( audioClip != null ) {
				audioSource.PlayOneShot( audioClip, volume );
			}
			else {
				audioSource.PlayOneShot( audioSource.clip, volume );
			}
		}
	}
}
