﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Simon_Says {
	public partial class Form1 : Form {
		int onInList = 0;
		List<int> pattern = new List<int>();
		Random rand = new Random();
		bool playback = false;

		public Form1() {
			InitializeComponent();
		}

		private void GUIPlayback() {
			playback = true;
			Thread.Sleep(200);
			foreach (int color in pattern) {
				switch(color){
					case 0:
					redButton.BackColor=Color.Red;
					Thread.Sleep(250);
					redButton.BackColor = Color.Transparent;
					break;
					case 1:
					blueButton.BackColor=Color.Blue;
					Thread.Sleep(250);
					blueButton.BackColor = Color.Transparent;
					break;
					case 2:
					yellowButton.BackColor=Color.Yellow;
					Thread.Sleep(250);
					yellowButton.BackColor = Color.Transparent;
					break;
					case 3:
					greenButton.BackColor=Color.Green;
					Thread.Sleep(250);
					greenButton.BackColor = Color.Transparent;
					break;
				}
				Thread.Sleep(200);
			}
			playback = false;
		}

		private void testCorrect(int buttonPressed) {
			if (playback) return;
			if (pattern[onInList] == buttonPressed) //BREAKS HERE
				onInList++;
			else {
				MessageBox.Show("Final Score: " + pattern.Count.ToString(),"You failed!");
				onInList = 0;
				pattern = new List<int>();
				new Thread(GUIPlayback).Start();
			}
			if (onInList >= pattern.Count) {
				pattern.Add(rand.Next(0, 4));
				onInList = 0;
				new Thread(GUIPlayback).Start();
			}
			scoreLabel.Text = "Score: " + pattern.Count;
			patternLabel.Text = "Item in pattern: " + onInList;
		}

		private void redButton_Click(object sender, EventArgs e) {
			testCorrect(0);
		}

		private void blueButton_Click(object sender, EventArgs e) {
			testCorrect(1);
		}

		private void yellowButton_Click(object sender, EventArgs e) {
			testCorrect(2);
		}

		private void greenButton_Click(object sender, EventArgs e) {
			testCorrect(3);
		}

		private void Form1_Load(object sender, EventArgs e) {
			pattern.Add(rand.Next(0, 4));
			new Thread(GUIPlayback).Start();
		}
	}
}
