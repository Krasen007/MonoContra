﻿namespace MonoBomber.Objects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class GameWin
    {
        public GameWin(SpriteBatch spriteBatch, SpriteFont gameFont, ContentManager content, GraphicsDeviceManager graphics)
        {
            this.Draw(spriteBatch, gameFont, content, graphics);
        }
        
        public void Draw(SpriteBatch spriteBatch, SpriteFont gameFont, ContentManager content, GraphicsDeviceManager graphics)
        {
            StaticItem gameWinScreen = new StaticItem(Vector2.Zero);
            gameWinScreen.SpriteTexture = content.Load<Texture2D>("gameWin");
            
            graphics.GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            spriteBatch.Draw(gameWinScreen.SpriteTexture, new Vector2(350, 300), Color.White);
            spriteBatch.DrawString(
                gameFont,
                "You completed the maze... but at what cost? " +
                "\n Press Enter to go deeper to the next level.",
                new Vector2(350, 150),
                Color.DarkKhaki);
            spriteBatch.End();
        }
    }
}
