﻿using System;
using System.Drawing;

namespace Aiv.Engine
{
	public class TextObject : GameObject
	{

		public string text;
		public Font font;
		public Brush brush;
		
		public TextObject (int x, int y, string text, string fontName, int fontSize, string colorName) : base(x, y)
		{
			this.text = text;
			this.font = new Font (fontName, fontSize);
			this.brush = new SolidBrush (Color.FromName (colorName));
			//Console.WriteLine ("Text created");
		}
			
		public override void Update() {
			base.Update();
			// ensure empty text on null
			string text = this.text;
			if (text == null)
				text = "";
			//Console.WriteLine ("drawing text");
			this.engine.workingGraphics.DrawString (text, this.font, this.brush, this.x, this.y);
		}
	}
}

