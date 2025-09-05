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
	public class LogoSprite
	{
		private Texture2D texture;

		private double animationTimer;

		private short animationFrame = 0;

		public void LoadContent(ContentManager content)
		{
			texture = content.Load<Texture2D>("wavysignature");
		}

		public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			animationTimer += gameTime.ElapsedGameTime.TotalSeconds;

			if (animationTimer > 0.7)
			{
				animationFrame++;
				if (animationFrame > 2) animationFrame = 0;
				animationTimer -= 0.7;
			}
			var source = new Rectangle(animationFrame * 32, 0, 32, 32);
			spriteBatch.Draw(texture, new Vector2(16,16), source, Color.White);
		}
	}
}
