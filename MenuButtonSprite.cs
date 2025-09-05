using InputExample;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevGame0
{
	
	public class MenuButtonSprite
	{
		private InputManager inputManager;
		private short currentButtonStyle;
		private Texture2D currentButtonTexture;
		private string buttonInContent;

		public MenuButtonSprite(string buttonSpecifier)
		{
			buttonInContent = buttonSpecifier;
		}
		public void LoadContent(ContentManager content)
		{
			currentButtonTexture = content.Load<Texture2D>(buttonInContent);
		}

		public Rectangle CurSprite(int state)
		{
			switch(state)
			{
				case 0:
					return new Rectangle();
				default: return new Rectangle();
			}
		}
	}
}
