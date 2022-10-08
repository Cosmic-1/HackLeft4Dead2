﻿namespace HackLeft4Dead2.Hack.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public ClassID ClassId { get; set; }
        public Rectangle PositionBox { get; set; }
        public (PointF pointA, PointF pointB) PositionLine { get; set; }
        public PointF PositionRadar { get; set; }
        public bool IsAlive { get; set; }
        public Team Team { get; set; }
        public int Health { get; set; }
        public float TopModel { get; set; }
    }
}
