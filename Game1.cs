using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameSprite
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D link;
        Vector2 linkPos;
        Rectangle linkRect;
        private Sprite sprite1;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
           // sprite1 = new Sprite(Texture2D texture, Vector2 position, Rectangle hitbox);
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
sprite1 = new Sprite(Content.Load<Texture2D>("link"));
            link=Content.Load<Texture2D>("link");
           linkPos=new Vector2(150,250);
           linkRect=new Rectangle((int)linkPos.X, (int)linkPos.Y, 200, 200);
        }

        protected override void Update(GameTime gameTime)
        {
              
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                    Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(link,linkRect,Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

//https://www.youtube.com/watch?v=F_q7XFmJhgs