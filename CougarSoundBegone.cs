using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;

namespace CougarSoundBegone
{
	public class CougarSoundBegoneMain : MelonMod
	{
		public override void OnInitializeMelon()
		{           

        }

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if (sceneName.Contains("MainMenu"))
			{
				GameObject stupidCougar = GameObject.Find("Audio/AUDIO_MainMenuDLC01/AudioMainMenuDLC01_Event_Cougar");

				if (stupidCougar != null)
                {
                    GameObject.DestroyImmediate(stupidCougar);
					MelonLogger.Msg("The cougar was destroyed!!!");
                }
			}

        }

        public override void OnUpdate()
		{

		}

    }
}