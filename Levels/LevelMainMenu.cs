﻿namespace MonoContra.Objects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class LevelMainMenu
    {
        private StaticItem backgrTree;

        public LevelMainMenu(ContentManager content)
        {
            this.LoadContent(content);
        }

        public void Draw(SpriteBatch spriteBatch, SpriteFont debugFont)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.backgrTree.SpriteTexture, new Vector2(300, 300), Color.White);
            spriteBatch.DrawString(
                debugFont,
                "Press enter or space to START GAME \n" +
                "W,A,S,D to move character, P for PAUSE, Esc for Exit.",
                new Vector2(600, 325), // GAME_WIDTH / 2 - 20, GAME_HEIGHT / 2 - 30),
                Color.CadetBlue);
            spriteBatch.End();
        }

        private void LoadContent(ContentManager content)
        {
            this.backgrTree = new StaticItem(new Vector2(125, 125), new Vector2(50f, 50f), new Vector2(0, 10));
            this.backgrTree.SpriteTexture = content.Load<Texture2D>("Tree");
        }
    }
}
