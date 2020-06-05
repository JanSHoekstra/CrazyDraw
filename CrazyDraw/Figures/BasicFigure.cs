﻿using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using System.Numerics;
using System.Collections.Generic;

namespace CrazyDraw.Figures
{
    partial class BasicFigure : IFigure
    {
        float posX;
        float posY;
        float width;
        float height;
        Color color = BLUE;
        bool mouseScaleReady = false;
        bool mouseScaleMode = false;
        bool selected = false;
        bool mouseMoveMode = false;
        Vector2 mousePositionLastFrame = new Vector2(0, 0);
        int uid;
        Strategy strat;

        public BasicFigure(float posX, float posY, float width, float height)//, Strategy strat)
        {
            this.posX = posX;
            this.posY = posY;
            this.width = width;
            this.height = height;
            //this.strat = strat;
        }

        public void Update() { }
        public void Draw() {
            DrawRectangleRec(Size(), color);
        }
        public int UID() { return 1; }
        public Rectangle Size() { return new Rectangle(posX, posY, width, height); }

    }
}