using InputExample;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevGame0
{
	/// <summary>
	/// Much of the button functionality was done with the tutorial "Monogame How to Create a Button Tutorial" by Computer Hobbyists - https://youtu.be/UOUFzdsq2dg?si=AkyohpIlv6I8TUSN 
	/// </summary>
	public class MenuButton
	{
		private InputManager inputManager;
		private Texture2D texture;
		private float buttonScale = 3.0f;
		public string Name { get; set; }
		public Vector2 Dimensions { get; set; } 
		public int ID { get; set; }
		public float LayerDepth {  get; set; }
		public bool Visible { get; set; }
		public Vector2 Position { get; set; }
		public Texture2D Texture { get; set; }
		public int CellWidth { get; set; }
		public int CellHeight { get; set; }
		public bool IsHovered { get; set; } = false;
		public bool IsClicked { get; set; } = false;
		public bool IsDisabled { get; set; } = false;

		public MenuButton(string name, Vector2 position)
		{
			Position = position;
			Name = name;
			Dimensions = ButtonSize();
		}

		public Rectangle AwesomeRectangleMaker()
		{
			if (IsDisabled) return new Rectangle(32, 32, 32, 32);
			else if (IsClicked) return new Rectangle(0, 32, 32, 32);
			else if (IsHovered) return new Rectangle(32, 0, 32, 32);
			else return new Rectangle(0, 0, 32, 32);
		}

		public Vector2 ButtonSize()
		{
			return new Vector2(Position.X + (32 * buttonScale), Position.Y + (32 * buttonScale));
		}

		#region Overloaded Methods

		public void LoadContent(ContentManager content)
		{
			texture = content.Load<Texture2D>(Name);
		}

		public void Update(GameTime gameTime)
		{
			/* Trying to figure out for next milestone
			if (Visible)
			{
				if (inputManager.CurrentMouseState.X > Position.X &&
					inputManager.CurrentMouseState.X < Dimensions.X &&
					inputManager.CurrentMouseState.Y > Position.Y &&
					inputManager.CurrentMouseState.Y < Dimensions.Y)
				{
					IsHovered = true;
					if (inputManager.CurrentMouseState.LeftButton == ButtonState.Pressed && inputManager.PriorMouseState.LeftButton == ButtonState.Released)
					{
						IsHovered = false;
						IsClicked = true;
					}
				}
				else
				{
					IsHovered = false;
				}
			}
			*/
		}

		public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, Position, AwesomeRectangleMaker(), Color.White,0f,new Vector2(0,0),buttonScale,SpriteEffects.None, 0);
		}

		#endregion
	}
}
