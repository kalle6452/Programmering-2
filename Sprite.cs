
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

//Microsoft Introduction to c# eller c# docs också Microsoft