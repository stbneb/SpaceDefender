﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDefender.States
{
    public abstract class State
    {
        protected Game1 _game;

        protected ContentManager _content;

        protected static Point _buttonSize = new Point(200, 50);

        protected static int _buttonsSpacing = 70;

        protected int _buttonXAlignment;

        protected int _buttonYAlignment;

        public State(Game1 game, ContentManager content)
        {
            _game = game;

            _content = content;

            _buttonXAlignment = (Game1.ScreenWidth / 2) - (_buttonSize.X / 2);

            _buttonYAlignment = (Game1.ScreenHeight / 2) - (_buttonSize.Y / 2);
        }

        public abstract void LoadContent();

        public abstract void Update(GameTime gameTime);

        public abstract void PostUpdate(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}