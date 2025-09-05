using InputExample;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Net.Quic;

namespace GameDevGame0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private InputManager inputManager;
        private SpriteBatch spriteBatch;

        private SpriteFont agency;
        private SpriteFont agencybuttons;

		/*
		private MenuButton playButton;
		private Vector2 playButtonPosition;

		private MenuButton settingsButton;
		private Vector2 settingsButtonPosition;

        private Texture2D quitTexture;
		private Vector2 quitButtonPosition;
        */
		private MenuButton quitButton;
        private LogoSprite logo;

		public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
			// TODO: Add your initialization logic here
            quitButton = new MenuButton(new Vector2(100,100));
            logo = new LogoSprite();
			base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
			// TODO: use this.Content to load your game content here
			agency = Content.Load<SpriteFont>("agency");
            agencybuttons = Content.Load<SpriteFont>("agencybuttons");

            quitButton.LoadContent(Content);
            logo.LoadContent(Content);
            
		}

		protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            quitButton.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSlateGray);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
			spriteBatch.DrawString(agency, "Infinite Games but No Games", new Vector2(16, graphics.GraphicsDevice.Viewport.Height / 2), Color.LightPink);
			spriteBatch.DrawString(agencybuttons, "To close the game, press 'esc' or the 'QUIT' button", new Vector2(16, (graphics.GraphicsDevice.Viewport.Height / 2) + 100), Color.LightPink);
			quitButton.Draw(gameTime, spriteBatch);
            logo.Draw(gameTime, spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
