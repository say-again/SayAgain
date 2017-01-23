﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Drawing;
//eventually make textbox into class for whole dialogue box (including name box)

namespace Test
{
    class DialogueBox: Drawable
    {
        public float w, h, x, y;
        public string content;
        public Color c;
        //public Dialogue line;
        public RectangleShape box;
        public RectangleShape nameBox;
        public void Draw(RenderTarget target, RenderStates states) {
            target.Draw(box);
            target.Draw(nameBox);
            //target.Draw(line);
            
        }
        
        public DialogueBox(float w, float h, float x, float y, string content, Color c)
        {
            this.w = w;
            this.h = h;
            this.x = x;
            this.y = y;
            this.c = c;
            this.content = content;
            
            box = new RectangleShape(new Vector2f(w, h));
            box.Position = new Vector2f(x, y);
            box.OutlineThickness = 3;
            box.OutlineColor = c;

            nameBox = new RectangleShape(new Vector2f(w-500, h-100));
            nameBox.Position = new Vector2f(x+40, y-35);
            nameBox.OutlineThickness = 3;
            nameBox.OutlineColor = c;

            //line = new Dialogue(x, y, content, c);
            //name = new Text(content, FontObjects.Adore64, 24);

        }

    }

    class Dialogue: Drawable
    {
        public float x, y;
        public string content;
        public Color Color;
        public Text dialogueText;
        public void Draw(RenderTarget target, RenderStates states) {
            target.Draw(dialogueText);
        }

        public Dialogue(float x, float y, string content, Color c)
        {
            this.x = x;
            this.y = y;
            this.content = content;
            this.Color = c;
            dialogueText = new Text(content, FontObjects.Adore64, 24);
            dialogueText.Color = Color;
            dialogueText.Position = new Vector2f(x, y);
        }
    }
}