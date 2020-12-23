﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yarisma : MonoBehaviour {

	public Text soruismi,cevapa,cevapb,cevapc,cevapd,skorYazi,zamanYazi;
	Sorular sr;

	public List<bool> sorulanlar;

	public int cevap,skor;
	public float zaman;


	void Start () {
		sr = GetComponent<Sorular> ();
		for (int i = 0; i < sr.sorular.Count; i++) {
			sorulanlar.Add (false);
		}
		SoruEkle ();
	}
	
	// Update is called once per frame
	void Update () {
		if (zaman > 0) {
			zaman -= Time.deltaTime;
			zamanYazi.text = zaman.ToString ("00");
		} else {
			zamanYazi.text = zaman.ToString ("GAME OVER CANiM ");
		}
	}


	public void SoruEkle(){
		for (int i = 0; i < sorulanlar.Count; i++) {

			if (sorulanlar [i] == false) {
				int sorusayi = Random.Range(0, sorulanlar.Count);
				if (sorulanlar [sorusayi] == false) {
					sorulanlar [sorusayi] = true;
					skor++;
					zaman = 25;
					skorYazi.text = "skor "+skor;
					soruismi.text = sr.sorular [sorusayi].soruismi;
					cevapa.text = sr.sorular [sorusayi].cevapa;
					cevapb.text = sr.sorular [sorusayi].cevapb;
					cevapc.text = sr.sorular [sorusayi].cevapc;
					cevapd.text = sr.sorular [sorusayi].cevapd;
					cevap = sr.sorular [sorusayi].cevap;
				} else {
						SoruEkle ();
					}
				break;
			}
			if(i == sorulanlar.Count-1) {
				skorYazi.text = skor.ToString ("KiNG iS BACK");
				cevapa.text = cevap.ToString ("BARiS BiLDi");
				cevapb.text = cevap.ToString ("BARiS BiLDi");
				cevapc.text = cevap.ToString ("BARiS BiLDi");
				cevapd.text = cevap.ToString ("BARiS BiLDi");
			}
		}

	}


	public void CevapVer(int deger){
		if (deger == cevap) {
			SoruEkle ();
		} else {
			skorYazi.text = skor.ToString ("CAHiLSiN");
		}
	}
}
