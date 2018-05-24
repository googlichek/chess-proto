﻿using UnityEngine;
using UnityEngine.UI;

namespace ChessProto
{
	public class Cell : MonoBehaviour
	{
		public int Row { get { return _row; } }
		public int Column { get { return _column; } }

		[Header("Cell Variables")]
		public bool Occupied = false;

		private int _row = 0;
		private int _column = 0;

		private Image _image = null;

		void OnEnable()
		{
			_image = GetComponent<Image>();
		}

		public void SetColor(Color color)
		{
			_image.color = color;
		}

		public void SetIndexes(int column, int row)
		{
			_row = row;
			_column = column;
		}
	}
}
