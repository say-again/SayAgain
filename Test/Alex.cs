﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Drawing;

namespace Test
{
    class Alex : Character
    {
        //private View _view;
        Texture t = new Texture("../../Art/alexMaster.png");
        string expr;
<<<<<<< HEAD
=======
        int longerframe;
>>>>>>> 24292412928b907bdb0e2cd81f7a16bf1fc4e303
        Dictionary<string, List<Sprite>> sprites = new Dictionary<string, List<Sprite>>() { { "angry", new List<Sprite>() },
                                                                                            { "happy", new List<Sprite>() },
                                                                                            { "neutral", new List<Sprite>() }
                                                                                           };
<<<<<<< HEAD

=======
        float framerate = 4f;
        int prevIndex = -1;
>>>>>>> 24292412928b907bdb0e2cd81f7a16bf1fc4e303

        public override void checkFNC()
        {
            throw new NotImplementedException();
        }

        public override void setSpriteEmotion(spriteEmotion e)
        {
            expr = e.ToString();
            
        }

<<<<<<< HEAD
        public override void Draw(RenderTarget target, RenderStates states)
        {

            float framerate = 4f;
=======
        public void pickSpecialFrame()
        {
            if (expr == "neutral")
            {
                longerframe = 0;
            }
            if (expr == "happy")
            {
                int rnd = r.Next(0, 4);

                if (rnd == 0)
                {
                    longerframe = 1;
                }
                else if (rnd == 1)
                {
                    longerframe = 4;

                }
                else if (rnd == 2)
                {
                    longerframe = 8;
                }
            }

            if (expr == "angry")
            {
                int rnd = r.Next(0, 4);

                if (rnd == 0)
                {
                    longerframe = 2;
                }
                else if (rnd == 1)
                {
                    longerframe = 8;

                }
            }
        }

        public override void Draw(RenderTarget target, RenderStates states)
        {
            rnd = r.Next(4, 14);
            
            // neutral expressoin
            //dont want draw to contain any logic about which expression,
            //so have the interested index defined somewhere else
            if (index == longerframe && prevIndex != longerframe)
            {
                framerate = framerate / (float)rnd;
                prevIndex = longerframe;
            }

            else if (index != longerframe)
            {
                prevIndex = index - 1;
                framerate = 4f;
            }
>>>>>>> 24292412928b907bdb0e2cd81f7a16bf1fc4e303

            target.Draw(sprites[expr][index]);
            if ((DateTime.Now - time).TotalMilliseconds > (1400f / framerate))
            {
                time = DateTime.Now;
<<<<<<< HEAD
                if (++index >= sprites.Count)
                {
=======
                if (++index >= sprites[expr].Count)
                {
                    pickSpecialFrame();
>>>>>>> 24292412928b907bdb0e2cd81f7a16bf1fc4e303
                    index = 0;
                }
            }
        }

        public Alex()
        {
<<<<<<< HEAD
=======
            FNCSpectrum[0] = 2;
            FNCSpectrum[1] = 5;
            FNCSpectrum[2] = 8;
            currentFNC = -1;

>>>>>>> 24292412928b907bdb0e2cd81f7a16bf1fc4e303
            //determine size and position
            xpos = (float)(SCREEN_WIDTH*0.5);
            ypos = (float)(SCREEN_HEIGHT*0.37);
            xscale = SCREEN_WIDTH / 1920;
            yscale = SCREEN_HEIGHT / 1080;

            for (int i = 0; i < (361 * 4); i += 361)
            {
                sprites["neutral"].Add(new Sprite(t, new IntRect(i, 0, 361, 449)));
                sprites["neutral"][sprites["neutral"].Count - 1].Scale = new Vector2f(xscale, yscale);
                sprites["neutral"][sprites["neutral"].Count - 1].Position = new Vector2f(xpos - sprites["neutral"][0].GetGlobalBounds().Width/2, ypos);
            }
            for (int i = 0; i < (361 * 9); i += 361)
            {
                sprites["happy"].Add(new Sprite(t, new IntRect(i, 449, 361, 449)));
                sprites["happy"][sprites["happy"].Count - 1].Scale = new Vector2f(xscale, yscale);
                sprites["happy"][sprites["happy"].Count - 1].Position = new Vector2f(xpos - sprites["happy"][0].GetGlobalBounds().Width/2, ypos);
            }
            for (int i = 0; i < (337 * 9); i += 337)
            {
                
                sprites["angry"].Add(new Sprite(t, new IntRect(i, 449 * 2, 337, 449)));
                sprites["angry"][sprites["angry"].Count - 1].Scale = new Vector2f(xscale, yscale);
                sprites["angry"][sprites["angry"].Count - 1].Position = new Vector2f(xpos - sprites["angry"][0].GetGlobalBounds().Width/2, ypos);
            }
        }
    }
}
