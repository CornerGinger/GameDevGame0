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

		private Vector2 logoVelocity;

		private Vector2 logoPosition;

		public void Initialize()
		{
			logoPosition = new Vector2(0, 0);
			logoVelocity = new Vector2(1, 0);
		}

		public void LoadContent(ContentManager content)
		{
			texture = content.Load<Texture2D>("wavysignature");
		}

		public void Update(GameTime gameTime, GraphicsDeviceManager graphics)
		{
			logoPosition += logoVelocity * 100 * (float)gameTime.ElapsedGameTime.TotalSeconds;
			if (logoPosition.X < graphics.GraphicsDevice.Viewport.X || logoPosition.X > graphics.GraphicsDevice.Viewport.Width - 32)
			{
				logoVelocity.X *= -1;
			}
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
			spriteBatch.Draw(texture, logoPosition, source, Color.White);
		}
	}
}
