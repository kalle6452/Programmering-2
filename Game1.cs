using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace uppgift_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
       private  SpriteBatch spriteBatch;
 Texture2D mario;
Vector2 marioPosition;
float marioSpeed;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
marioPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
_graphics.PreferredBackBufferHeight / 2);
marioSpeed = 100f;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
  mario = Content.Load<Texture2D>("mario");
            // TODO: use this.Content to load your game content here
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
var kstate = Keyboard.GetState();
if(kstate.IsKeyDown(Keys.Right))
    marioPosition.X += marioSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

spriteBatch.Begin();
    spriteBatch.Draw(mario, marioPosition, Color.White);
    spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
