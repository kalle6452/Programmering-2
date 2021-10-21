using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
public class Sprite {
    private Texture2D texture {get;set;}
    public Vector2 position{get;set;}
    public Rectangle hitbox{get;set;}
    public Sprite(Texture2D texture)
    {
        this.texture = texture;
        this.position = position;
        this.hitbox = hitbox;
    }
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D link;
        Vector2 linkPos;
        Rectangle linkRect;
        private Sprite sprite1;
    
     public void Update()
    {
      if (Keyboard.GetState().IsKeyDown(Keys.W))
      {
        linkPos.Y -= 10;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.S))
      {
        linkPos.Y += 10;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.A))
      {
         linkPos.X -= 10;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.D))
      {
        linkPos.X += 10;
      }
    }
    public void Draw(SpriteBatch spriteBatch){
         spriteBatch.Draw(_texture, Position, Color.White);
    }
        }


//Microsoft Introduction to c# eller c# docs också Microsoft