using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Sprite {
    private Texture2D texture {get;set;}
    public Vector2 position{get;set;}
    public Rectangle hitbox{get;set;}
    public Sprite(Texture2D texture, Vector2 position, Rectangle hitbox)
    {
        this.texture = texture;
        this.position = position;
        this.hitbox = hitbox;
    }
}

Microsoft Introduction to c# eller c# docs också Microsoft


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameSprite
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D xwing;
        Vector2 xwingPos;
        Rectangle xwingRect;
        private Sprite sprite1;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            sprite1 = new Sprite(Content.Load<Texture2D>("xwing"));
            xwingPos=new Vector2(150,250);
            xwingRect=new Rectangle((int)xwingPos.X, (int)xwingPos.Y, 200, 200);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            xwing=Content.Load<Texture2D>("xwing");
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
            _spriteBatch.Draw(xwing,xwingRect,Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
