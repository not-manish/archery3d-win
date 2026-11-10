using System.Collections.Generic;
using UnityEngine;

public class MusicCtrl : MonoBehaviour
{
	public List<AudioClip> SceneBGMusic;

	public AudioClip background;

	private AudioClip bg_club;

	private AudioClip bg_park;

	private AudioClip bg_beach;

	private AudioClip bg_forest;

	private AudioClip bg_villa;

	private AudioClip bg_remains;

	public AudioClip main_Chest;

	public AudioClip chest_bg;

	public AudioClip chest_fall;

	public AudioClip chest_shake;

	public AudioClip chest_open;

	public AudioClip chest_card;

	public AudioClip chest_newcard;

	public AudioClip chest_progress;

	public AudioClip reward_bomb;

	public AudioClip collect_coin;

	public AudioClip collect_diamond;

	public AudioClip collect_card;

	public AudioClip main_click;

	public AudioClip main_close;

	public AudioClip main_rank;

	public AudioClip game_ready;

	public AudioClip game_go;

	public AudioClip game_finish;

	public AudioClip target_one;

	public AudioClip target_two;

	public AudioClip target_three;

	public AudioClip target_four;

	public AudioClip target_five;

	public AudioClip target_six;

	public AudioClip target_seven;

	public AudioClip target_eight;

	public AudioClip target_nine;

	public AudioClip target_ten;

	public AudioClip target_great;

	public AudioClip target_perfect;

	public AudioClip target_wonderful;

	public AudioClip target_fantastic;

	public AudioClip target_unbelievable;

	public AudioClip game_drawbowfirst;

	public AudioClip game_drawbow;

	public AudioClip game_charge;

	public AudioClip game_shoot;

	public AudioClip game_arrowfly;

	public AudioClip game_bingo;

	public AudioClip game_balloon;

	public AudioClip game_bottle;

	public AudioClip game_fruit;

	public AudioClip game_volleyball;

	public AudioClip game_tips;

	public AudioClip game_star;

	public AudioClip game_clock;

	public AudioClip game_clap1;

	public AudioClip game_clap2;

	public AudioClip game_clap3;

	public AudioClip game_clap4;

	public AudioClip game_miss;

	public AudioClip chongci_game_clock;

	public AudioClip game_round;

	public AudioClip game_part1;

	public AudioClip game_part2;

	public AudioClip game_part3;

	public AudioClip bg_roulette;

	public AudioClip roulette_turn;

	public AudioClip roulette_win;

	public AudioClip roulette_bigwin;

	public AudioClip matching_enter;

	public AudioClip matching_search;

	public AudioClip matching_trophy;

	public AudioClip matching_chest;

	public AudioClip matching_success;

	public AudioClip result_addscore;

	public AudioClip result_win;

	public AudioClip result_lose;

	public AudioClip result_matchwin;

	public AudioClip equip_upgrade;

	public AudioClip equip_number;

	public AudioClip equip_number1;

	private static MusicCtrl instance;

	public AudioSource BGSoundContral;

	public List<AudioSource> EffectSoundContral;

	public AudioSource rouletteBGSoundContral;

	private Dictionary<soundEffect, AudioClip> map;

	public static int MAX_NUM;

	public static MusicCtrl Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void init()
	{
	}

	private void Awake()
	{
	}

	private AudioSource GetFreeSource()
	{
		return null;
	}

	public void PlayEffectSound(soundEffect audioClipId, float volume = 1f, float pitch = 1f, bool isLoop = false)
	{
	}

	public void StopLoopEffectSound(soundEffect audioClipId)
	{
	}

	public void StopAllLoopEffectSound()
	{
	}

	private AudioClip GetBgClip(SceneType sceneType)
	{
		return null;
	}

	public void BGMusciSoundPlay()
	{
	}

	public void BGMusciSoundPlay(SceneType sceneType)
	{
	}

	public void BGMusicPlayScene2(AudioClip clip)
	{
	}

	public void ChangeBGMusciVolume(float Volume)
	{
	}

	public void BGMusciSoundCtrl(bool isOn)
	{
	}

	public void EffectMusciSoundStop(bool isOn)
	{
	}

	public void RouletteBGSoundPlay(soundEffect bgType, float volume = 1f)
	{
	}

	public void RouletteBGSoundStop()
	{
	}
}
