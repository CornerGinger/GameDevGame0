using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace InputExample
{
	public class InputManager
	{
		KeyboardState currentKeyboardState;
		KeyboardState priorKeyboardState;
		public MouseState CurrentMouseState { get; private set; }
		public MouseState PriorMouseState { get; private set; }

		GamePadState currentGamePadState;
		GamePadState priorGamePadState;

		/// <summary>
		/// The current direction
		/// </summary>
		public Vector2 Direction { get; private set; }

		/// <summary>
		/// If the user has requested the game end 
		/// </summary>
		public bool Exit { get; private set; } = false;

		public void Update(GameTime gameTime)
		{
			#region Updating Input State
			priorKeyboardState = currentKeyboardState;
			currentKeyboardState = Keyboard.GetState();

			PriorMouseState = CurrentMouseState;
			CurrentMouseState = Mouse.GetState();

			priorGamePadState = currentGamePadState;
			currentGamePadState = GamePad.GetState(0);
			#endregion

			#region Direction Input
			/*
			//Get postition from GamePad
			Direction = currentGamePadState.ThumbSticks.Right * 100 * (float)gameTime.ElapsedGameTime.TotalSeconds;

			//Get position from Keyboard
			if (currentKeyboardState.IsKeyDown(Keys.Left) || currentKeyboardState.IsKeyDown(Keys.A))
			{
				Direction += new Vector2(-100 * (float)gameTime.ElapsedGameTime.TotalSeconds, 0);
			}
			if (currentKeyboardState.IsKeyDown(Keys.Right) || currentKeyboardState.IsKeyDown(Keys.D))
			{
				Direction += new Vector2(100 * (float)gameTime.ElapsedGameTime.TotalSeconds, 0);
			}
			if (currentKeyboardState.IsKeyDown(Keys.Up) || currentKeyboardState.IsKeyDown(Keys.W))
			{
				Direction += new Vector2(0, -100 * (float)gameTime.ElapsedGameTime.TotalSeconds);
			}
			if (currentKeyboardState.IsKeyDown(Keys.Down) || currentKeyboardState.IsKeyDown(Keys.S))
			{
				Direction += new Vector2(0, 100 * (float)gameTime.ElapsedGameTime.TotalSeconds);
			}
			*/
			#endregion
			

			#region Mouse Button Detection

			/*if (CurrentMouseState.LeftButton == ButtonState.Pressed && PriorMouseState.LeftButton == ButtonState.Released) 
			{

			}
			*/

			#endregion

			#region Exit Input


			if (currentGamePadState.Buttons.Back == ButtonState.Pressed || currentKeyboardState.IsKeyDown(Keys.Escape))
			{
				Exit = true;
			}
			#endregion
		}
	}
}
