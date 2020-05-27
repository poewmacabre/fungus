// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

/*This script has been, partially or completely, generated by the Fungus.GenerateVariableWindow*/
using UnityEngine;


namespace Fungus
{
    /// <summary>
    /// AudioMixerGroup variable type.
    /// </summary>
    [VariableInfo("Other", "AudioMixerGroup")]
    [AddComponentMenu("")]
	[System.Serializable]
	public class AudioMixerGroupVariable : VariableBase<UnityEngine.Audio.AudioMixerGroup>
	{ }

	/// <summary>
	/// Container for a AudioMixerGroup variable reference or constant value.
	/// </summary>
	[System.Serializable]
	public struct AudioMixerGroupData
	{
		[SerializeField]
		[VariableProperty("<Value>", typeof(AudioMixerGroupVariable))]
		public AudioMixerGroupVariable audioMixerGroupRef;

		[SerializeField]
		public UnityEngine.Audio.AudioMixerGroup audioMixerGroupVal;

		public static implicit operator UnityEngine.Audio.AudioMixerGroup(AudioMixerGroupData AudioMixerGroupData)
		{
			return AudioMixerGroupData.Value;
		}

		public AudioMixerGroupData(UnityEngine.Audio.AudioMixerGroup v)
		{
			audioMixerGroupVal = v;
			audioMixerGroupRef = null;
		}

		public UnityEngine.Audio.AudioMixerGroup Value
		{
			get { return (audioMixerGroupRef == null) ? audioMixerGroupVal : audioMixerGroupRef.Value; }
			set { if (audioMixerGroupRef == null) { audioMixerGroupVal = value; } else { audioMixerGroupRef.Value = value; } }
		}

		public string GetDescription()
		{
			if (audioMixerGroupRef == null)
			{
				return audioMixerGroupVal.ToString();
			}
			else
			{
				return audioMixerGroupRef.Key;
			}
		}
	}
}