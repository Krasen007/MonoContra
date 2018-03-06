﻿namespace MonoContra.Objects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Door : AnimatedSprite
    {
        private const int ANIMATION_SPEED = 9;
        private int animaSpeedIncrement;   

        public Door(Texture2D texture, int rows, int cols, Vector2 spritePos) : base(texture, rows, cols, spritePos)
        {
            this.LevelComplete = false;
        }

        public bool LevelComplete { get; set; }

        public void Update(Player player)
        {
            if (player.DestinationRectangle.Intersects(this.DestinationRectangle))
            {
                // this.HandlePlayerCollision(player);
                // If player contains key
                if (player.DestinationRectangle.Intersects(this.DestinationRectangle) && player.HasKey)
                {
                    // Exit game, go to next level
                    this.OpenDoorAnim();
                    this.HandlePlayerCollision(player);
                }
            }
        }

        private void OpenDoorAnim()
        {
            this.animaSpeedIncrement++;

            if (this.animaSpeedIncrement >= ANIMATION_SPEED)
            {
                this.CurrentFrame++;
                if (this.CurrentFrame >= this.TotalFrames)
                {
                    this.CurrentFrame = this.TotalFrames - 1;
                }

                this.animaSpeedIncrement = 0;
            }
        }

        private void HandlePlayerCollision(Player player)
        {
            // TODO: do stuff
            this.LevelComplete = true;
        }
    }
}
